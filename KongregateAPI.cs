using UnityEngine;
using System.Collections;

public class KongregateAPI : MonoBehaviour
{
    static bool KONGREGATE_LOADED = false;
    static int USER_ID = 0;
    static string USER_NAME = "Guest";
    static string GAME_AUTH_TOKEN = "";


    void start()
    { 
    Application.ExternalEval(
 "if(typeof(kongregateUnitySupport) != 'undefined'){" +
 " kongregateUnitySupport.initAPI('MyUnityO­bject', 'OnKongregateAPILoaded');" +
 "};"
);    
    }

    void OnKongregateAPILoaded (string UserInfo)
    {
        KONGREGATE_LOADED = true;

        string[] userStats = UserInfo.Split("|"[0]);
        USER_ID = int.Parse(userStats[0]);
        USER_NAME = userStats[1];
        GAME_AUTH_TOKEN = userStats[2];
    }

    public static bool APILoaded()
    {
        if (USER_NAME != "Guest" && KONGREGATE_LOADED)
            return true;
        else
            return false;        
    }

    public static void SubmitData(string dateName, int dataValue)
    {
        if (APILoaded())
        {
            Application.ExternalCall("kongregate.stats.submit", dateName, dataValue);
        }

    }


}




