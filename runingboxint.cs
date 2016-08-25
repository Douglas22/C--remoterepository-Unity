using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class runingboxint : MonoBehaviour {

    public static int xx = 0;

    public static int point1= 0;
    public static double number1 = 0;     
    public static double placeholder1 = 1;

    public static int point2 = 0;
    public static double number2 = 0;
    public static double placeholder2 = 1;

    public static int point3 = 0;
    public static double number3 = 0;
    public static double placeholder3 = 1;

    public static int point4 = 0;
    public static double number4 = 0;
    public static double placeholder4 = 1;

    public static int point5 = 0;
    public static double number5 = 0;
    public static double placeholder5 = 1;

    public static int point6 = 0;
    public static double number6 = 0;
    public static double placeholder6 = 1;

    public static int XYZ = 0;

    void start()
    {
        //testing = "hears from script";
        
    }
    
   
    void Update ()
    {




        if (xx >= 1 & xx <= 1)
        {
            //to tab through buttons
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                print("tab tab");
                xx = 2;
                justforText2.Text2.color = Color.green;
                justforText3.Text3.color = Color.black; //text3 is on button 1
            }
            //to tab through buttons
            if (point1> 1)
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    number1 = 0;
                    placeholder1     = 1;
                    point1 = 0;
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
                {
                   
                    number1 = -number1;
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
                {
                    placeholder1     = placeholder1     * 0.1;
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    placeholder1     = placeholder1     * 0.1;
                    number1 = number1 + (1 * placeholder1    );
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    placeholder1     = placeholder1     * 0.1;
                    number1 = number1 + (2 * placeholder1    );
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    placeholder1     = placeholder1     * 0.1;
                    number1 = number1 + (3 * placeholder1    );
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
                {
                    placeholder1     = placeholder1     * 0.1;
                    number1 = number1 + (4 * placeholder1    );
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
                {
                    placeholder1     = placeholder1     * 0.1;
                    number1 = number1 + (5 * placeholder1     );
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
                {
                    placeholder1     = placeholder1     * 0.1;
                    number1 = number1 + (6 * placeholder1    );
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
                {
                    placeholder1     = placeholder1     * 0.1;
                    number1 = number1 + (7 * placeholder1     );
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
                {
                    placeholder1     = placeholder1     * 0.1;
                    number1 = number1 + (8 * placeholder1     );
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
                {
                    placeholder1     = placeholder1     * 0.1;
                    number1 = number1 + (9 * placeholder1     );
                    print(number1);
                }
            }
            //if (point1< 1)
            else
            //print("yes is 1");
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    number1 = 0;
                    print(number1);
                }

                else if (Input.GetKeyDown(KeyCode.Period) || Input.GetKeyDown(KeyCode.KeypadPeriod))
                {
                    point1= 2;
                    print(number1 + ".");
                }
                else if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
                {
                    number1 = -number1;
                    print(number1);
                }
                //
                else if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
                //
                {
                    number1 = (number1 * 10);
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    number1 = 1 + (number1 * 10);
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    number1 = 2 + (number1 * 10);
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    number1 = 3 + (number1 * 10);
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
                {
                    number1 = 4 + (number1 * 10);
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
                {
                    number1 = 5 + (number1 * 10);
                    print(number1);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
                {
                    number1 = 6 + (number1 * 10);
                    print(number1);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
                {
                    number1 = 7 + (number1 * 10);
                    print(number1);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
                {
                    number1 = 8 + (number1 * 10);
                    print(number1);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
                {
                    number1 = 9 + (number1 * 10);
                    print(number1);
                }

                /*if (Input.GetKeyDown(KeyCode.Alpha1))
                {


                    powers = (Mathf.Pow(10, placeholder));
                    number1 = number1 + (powers);
                    placeholder = placeholder + 1;
                    print(number1);
                }*/

            }
            //replace with 
        }        /*else
                print("no its not 1 its 0");*/
        else if (xx >= 2 & xx <= 2)
        {
            
            //to tab through buttons
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                print("tab tab");
                xx = 3;
                justforText.Text1.color = Color.green;
                justforText2.Text2.color = Color.black; 
            }
            //to tab through buttons
            if (point2 > 1)
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    number2 = 0;
                    placeholder2 = 1;
                    point2 = 0;
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
                {
                    number2 = -number2;
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
                {
                    placeholder2 = placeholder2 * 0.1;
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    placeholder2 = placeholder2 * 0.1;
                    number2 = number2 + (1 * placeholder2);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    placeholder2 = placeholder2 * 0.1;
                    number2 = number2 + (2 * placeholder2);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    placeholder2 = placeholder2 * 0.1;
                    number2 = number2 + (3 * placeholder2);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
                {
                    placeholder2 = placeholder2 * 0.1;
                    number2 = number2 + (4 * placeholder2);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
                {
                    placeholder2 = placeholder2 * 0.1;
                    number2 = number2 + (5 * placeholder2);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
                {
                    placeholder2 = placeholder2 * 0.1;
                    number2 = number2 + (6 * placeholder2);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
                {
                    placeholder2 = placeholder2 * 0.1;
                    number2 = number2 + (7 * placeholder2);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
                {
                    placeholder2 = placeholder2 * 0.1;
                    number2 = number2 + (8 * placeholder2);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
                {
                    placeholder2 = placeholder2 * 0.1;
                    number2 = number2 + (9 * placeholder2);
                    print(number2);
                }
            }
            //if (point2 < 1)
            else
            //print("yes is 1");
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    number2 = 0;
                    print(number2);
                }

                else if (Input.GetKeyDown(KeyCode.Period) || Input.GetKeyDown(KeyCode.KeypadPeriod))
                {
                    point2 = 2;
                    print(number2 + ".");
                }
                else if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
                {
                    number2 = -number2;
                    print(number2);
                }
                //
                else if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
                //
                {
                    number2 = (number2 * 10);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    number2 = 1 + (number2 * 10);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    number2 = 2 + (number2 * 10);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    number2 = 3 + (number2 * 10);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
                {
                    number2 = 4 + (number2 * 10);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
                {
                    number2 = 5 + (number2 * 10);
                    print(number2);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
                {
                    number2 = 6 + (number2 * 10);
                    print(number2);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
                {
                    number2 = 7 + (number2 * 10);
                    print(number2);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
                {
                    number2 = 8 + (number2 * 10);
                    print(number2);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
                {
                    number2 = 9 + (number2 * 10);
                    print(number2);
                }



            }//////end of this bit
        }
        else if (xx >= 3 & xx <= 3)
            //to tab through buttons
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                print("tab asss");
                xx = 4;
                justforText4.Text4.color = Color.green;
                justforText.Text1.color = Color.black; 
            }
            else
            //to tab through buttons
             {
            //number3 = 5;
            //print("test work " + number3);
            if (point3 > 1)
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    number3 = 0;
                    placeholder3 = 1;
                    point3 = 0;
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
                {
                    number3 = -number3;
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
                {
                    placeholder3 = placeholder3 * 0.1;
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    placeholder3 = placeholder3 * 0.1;
                    number3 = number3 + (1 * placeholder3);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    placeholder3 = placeholder3 * 0.1;
                    number3 = number3 + (2 * placeholder3);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    placeholder3 = placeholder3 * 0.1;
                    number3 = number3 + (3 * placeholder3);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
                {
                    placeholder3 = placeholder3 * 0.1;
                    number3 = number3 + (4 * placeholder3);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
                {
                    placeholder3 = placeholder3 * 0.1;
                    number3 = number3 + (5 * placeholder3);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
                {
                    placeholder3 = placeholder3 * 0.1;
                    number3 = number3 + (6 * placeholder3);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
                {
                    placeholder3 = placeholder3 * 0.1;
                    number3 = number3 + (7 * placeholder3);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
                {
                    placeholder3 = placeholder3 * 0.1;
                    number3 = number3 + (8 * placeholder3);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
                {
                    placeholder3 = placeholder3 * 0.1;
                    number3 = number3 + (9 * placeholder3);
                    print(number3);
                }
            }
            //if (point3 < 1)
            else
            //print("yes is 1");
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    number3 = 0;
                    print(number3);
                }

                else if (Input.GetKeyDown(KeyCode.Period) || Input.GetKeyDown(KeyCode.KeypadPeriod))
                {
                    point3 = 2;
                    print(number3 + ".");
                }
                else if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
                {
                    number3 = -number3;
                    print(number3);
                }
                //
                else if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
                //
                {
                    number3 = (number3 * 10);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    number3 = 1 + (number3 * 10);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    number3 = 2 + (number3 * 10);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    number3 = 3 + (number3 * 10);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
                {
                    number3 = 4 + (number3 * 10);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
                {
                    number3 = 5 + (number3 * 10);
                    print(number3);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
                {
                    number3 = 6 + (number3 * 10);
                    print(number3);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
                {
                    number3 = 7 + (number3 * 10);
                    print(number3);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
                {
                    number3 = 8 + (number3 * 10);
                    print(number3);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
                {
                    number3 = 9 + (number3 * 10);
                    print(number3);
                }



            }

        }


        else if (xx >= 4 & xx <= 4)
        {

            //to tab through buttons
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                print("tab tab");
                xx = 5;
                justforText5.Text5.color = Color.green;
                justforText4.Text4.color = Color.black;
            }
            //to tab through buttons
            if (point4 > 1)
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    number4 = 0;
                    placeholder4 = 1;
                    point4 = 0;
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
                {
                    number4 = -number4;
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
                {
                    placeholder4 = placeholder4 * 0.1;
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    placeholder4 = placeholder4 * 0.1;
                    number4 = number4 + (1 * placeholder4);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    placeholder4 = placeholder4 * 0.1;
                    number4 = number4 + (2 * placeholder4);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    placeholder4 = placeholder4 * 0.1;
                    number4 = number4 + (3 * placeholder4);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
                {
                    placeholder4 = placeholder4 * 0.1;
                    number4 = number4 + (4 * placeholder4);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
                {
                    placeholder4 = placeholder4 * 0.1;
                    number4 = number4 + (5 * placeholder4);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
                {
                    placeholder4 = placeholder4 * 0.1;
                    number4 = number4 + (6 * placeholder4);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
                {
                    placeholder4 = placeholder4 * 0.1;
                    number4 = number4 + (7 * placeholder4);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
                {
                    placeholder4 = placeholder4 * 0.1;
                    number4 = number4 + (8 * placeholder4);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
                {
                    placeholder4 = placeholder4 * 0.1;
                    number4 = number4 + (9 * placeholder4);
                    print(number4);
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    number4 = 0;
                    print(number4);
                }

                else if (Input.GetKeyDown(KeyCode.Period) || Input.GetKeyDown(KeyCode.KeypadPeriod))
                {
                    point4 = 2;
                    print(number4 + ".");
                }
                else if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
                {
                    number4 = -number4;
                    print(number4);
                }
                //
                else if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
                //
                {
                    number4 = (number4 * 10);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    number4 = 1 + (number4 * 10);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    number4 = 2 + (number4 * 10);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    number4 = 3 + (number4 * 10);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
                {
                    number4 = 4 + (number4 * 10);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
                {
                    number4 = 5 + (number4 * 10);
                    print(number4);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
                {
                    number4 = 6 + (number4 * 10);
                    print(number4);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
                {
                    number4 = 7 + (number4 * 10);
                    print(number4);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
                {
                    number4 = 8 + (number4 * 10);
                    print(number4);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
                {
                    number4 = 9 + (number4 * 10);
                    print(number4);
                }
            }

        }
        else if (xx >= 5 & xx <= 5)
        {
            //to tab through buttons
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                print("tab tab");
                xx = 6;
                justforText6.Text6.color = Color.green;
                justforText5.Text5.color = Color.black;
            }
            //to tab through buttons
            if (point5 > 1)
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    number5 = 0;
                    placeholder5 = 1;
                    point5 = 0;
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
                {
                    number5 = -number5;
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
                {
                    placeholder5 = placeholder5 * 0.1;
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    placeholder5 = placeholder5 * 0.1;
                    number5 = number5 + (1 * placeholder5);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    placeholder5 = placeholder5 * 0.1;
                    number5 = number5 + (2 * placeholder5);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    placeholder5 = placeholder5 * 0.1;
                    number5 = number5 + (3 * placeholder5);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
                {
                    placeholder5 = placeholder5 * 0.1;
                    number5 = number5 + (4 * placeholder5);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
                {
                    placeholder5 = placeholder5 * 0.1;
                    number5 = number5 + (5 * placeholder5);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
                {
                    placeholder5 = placeholder5 * 0.1;
                    number5 = number5 + (6 * placeholder5);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
                {
                    placeholder5 = placeholder5 * 0.1;
                    number5 = number5 + (7 * placeholder5);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
                {
                    placeholder5 = placeholder5 * 0.1;
                    number5 = number5 + (8 * placeholder5);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
                {
                    placeholder5 = placeholder5 * 0.1;
                    number5 = number5 + (9 * placeholder5);
                    print(number5);
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    number5 = 0;
                    print(number5);
                }

                else if (Input.GetKeyDown(KeyCode.Period) || Input.GetKeyDown(KeyCode.KeypadPeriod))
                {
                    point5 = 2;
                    print(number5 + ".");
                }
                else if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
                {
                    number5 = -number5;
                    print(number5);
                }
                //
                else if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
                //
                {
                    number5 = (number5 * 10);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    number5 = 1 + (number5 * 10);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    number5 = 2 + (number5 * 10);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    number5 = 3 + (number5 * 10);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
                {
                    number5 = 4 + (number5 * 10);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
                {
                    number5 = 5 + (number5 * 10);
                    print(number5);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
                {
                    number5 = 6 + (number5 * 10);
                    print(number5);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
                {
                    number5 = 7 + (number5 * 10);
                    print(number5);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
                {
                    number5 = 8 + (number5 * 10);
                    print(number5);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
                {
                    number5 = 9 + (number5 * 10);
                    print(number5);
                }
            }
        }


        else if (xx >= 6 & xx <= 6)
        {
            //to tab through buttons
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                print("tab tab");
                xx = 1;
                justforText3.Text3.color = Color.green;//text 3 on button 1 and text 1 on 3
                justforText6.Text6.color = Color.black;
            }
            else
            //to tab through buttons
            if (point6 > 1)
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    number6 = 0;
                    placeholder6 = 1;
                    point6 = 0;
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
                {
                    number6 = -number6;
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
                {
                    placeholder6 = placeholder6 * 0.1;
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    placeholder6 = placeholder6 * 0.1;
                    number6 = number6 + (1 * placeholder6);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    placeholder6 = placeholder6 * 0.1;
                    number6 = number6 + (2 * placeholder6);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    placeholder6 = placeholder6 * 0.1;
                    number6 = number6 + (3 * placeholder6);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
                {
                    placeholder6 = placeholder6 * 0.1;
                    number6 = number6 + (4 * placeholder6);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
                {
                    placeholder6 = placeholder6 * 0.1;
                    number6 = number6 + (5 * placeholder6);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
                {
                    placeholder6 = placeholder6 * 0.1;
                    number6 = number6 + (6 * placeholder6);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
                {
                    placeholder6 = placeholder6 * 0.1;
                    number6 = number6 + (7 * placeholder6);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
                {
                    placeholder6 = placeholder6 * 0.1;
                    number6 = number6 + (8 * placeholder6);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
                {
                    placeholder6 = placeholder6 * 0.1;
                    number6 = number6 + (9 * placeholder6);
                    print(number6);
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Backspace))
                {
                    number6 = 0;
                    print(number6);
                }

                else if (Input.GetKeyDown(KeyCode.Period) || Input.GetKeyDown(KeyCode.KeypadPeriod))
                {
                    point6 = 2;
                    print(number6 + ".");
                }
                else if (Input.GetKeyDown(KeyCode.KeypadMinus) || Input.GetKeyDown(KeyCode.Minus))
                {
                    number6 = -number6;
                    print(number6);
                }
                //
                else if (Input.GetKeyDown(KeyCode.Alpha0) || Input.GetKeyDown(KeyCode.Keypad0))
                //
                {
                    number6 = (number6 * 10);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
                {
                    number6 = 1 + (number6 * 10);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
                {
                    number6 = 2 + (number6 * 10);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
                {
                    number6 = 3 + (number6 * 10);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
                {
                    number6 = 4 + (number6 * 10);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
                {
                    number6 = 5 + (number6 * 10);
                    print(number6);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
                {
                    number6 = 6 + (number6 * 10);
                    print(number6);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
                {
                    number6 = 7 + (number6 * 10);
                    print(number6);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
                {
                    number6 = 8 + (number6 * 10);
                    print(number6);
                }

                else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
                {
                    number6 = 9 + (number6 * 10);
                    print(number6);
                }
            }
        }

    }
    
}
