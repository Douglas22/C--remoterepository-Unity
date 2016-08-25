using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class justforText : MonoBehaviour
{




    public static double number3;
    public static Text Text1;
    //Text Text1;

    void Start()
    {
        Text1 = GetComponent<Text>();
    }


    void Update()
    {
        Text1.text = "=  " + runingboxint.number3 ;

    }
}
