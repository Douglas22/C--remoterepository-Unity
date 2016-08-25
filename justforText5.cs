using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class justforText5 : MonoBehaviour
{

    public static double number5;
    public static Text Text5;
    //Text Text5;

    void Start()
    {
        Text5 = GetComponent<Text>();
    }


    void Update()
    {
        Text5.text = runingboxint.number5 + " Y";

    }
}