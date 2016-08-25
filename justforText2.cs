using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class justforText2 : MonoBehaviour {

    public static double number2;
    //Text Text2;
    public static Text Text2;

    void Start ()
    {
        Text2 = GetComponent<Text>();
    }
	

	void Update ()
    {
        Text2.text = runingboxint.number2 + " Y";
    }
}
