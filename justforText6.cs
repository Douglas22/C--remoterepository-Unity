using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class justforText6 : MonoBehaviour
{

    public static double number6;
    public static Text Text6;
    //Text Text6;

    void Start()
    {
        Text6 = GetComponent<Text>();
    }


    void Update()
    {
        Text6.text = "= " + runingboxint.number6 ;

    }
}