using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ForAnswerText : MonoBehaviour {
    private static double NC15;
    private static double NC24;
    private static double NC34;
    private static double NC16;

    private static double NC53;
    private static double NC26;
    //public static double number1;
    //public static float Log(float f, float p);
    public static Text AnswerText;

    void Start () {
        AnswerText = GetComponent<Text>();
    }
	
	
	void Update () {
        NC15 = (runingboxint.number1 * runingboxint.number5) ;
        NC24 = (runingboxint.number2 * runingboxint.number4) ;
        NC34 = (runingboxint.number3 * runingboxint.number4);
        NC16 = (runingboxint.number1 * runingboxint.number6);
        NC53 = (runingboxint.number5 * runingboxint.number3);
        NC26 = (runingboxint.number2 * runingboxint.number6);

        
        
        AnswerText.text = "X = " +  (NC53 - NC26) / (NC15 - NC24) + " and Y = " + (NC34 - NC16)/(NC24 - NC15);
            
    }
}
//yes
//yes
//repaced
//yes
