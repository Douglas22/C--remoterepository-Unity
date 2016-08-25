using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class justforText4 : MonoBehaviour
{

    public static double number4;
    public static Text Text4;
    //Text Text4;

    void Start()
    {
        Text4 = GetComponent<Text>();
    }


    void Update()
    {
        Text4.text = runingboxint.number4 + " X" + " +";

    }
}