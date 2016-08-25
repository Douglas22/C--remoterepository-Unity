using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class justforText3 : MonoBehaviour {

    public static double number1;
    public static Text Text3;
    
    //Text Text3;

    void Start ()
    {
        Text3 = GetComponent<Text>();
    }
	
	
	void Update ()
    {
        
            Text3.text =  runingboxint.number1 + " X +" ;
        
    }
}
