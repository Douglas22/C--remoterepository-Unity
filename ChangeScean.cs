using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeScean : MonoBehaviour {

    

    public void ChangeToScene (int sceneToChangeTo) {

        
        //public static Text justforText3;

        
            if (sceneToChangeTo > 0 & sceneToChangeTo <= 1 )
            {
            justforText.Text1.color = Color.black;
            justforText2.Text2.color = Color.black;
            justforText4.Text4.color = Color.black;
            justforText5.Text5.color = Color.black;
            justforText6.Text6.color = Color.black;
            if (runingboxint.xx > 1 || runingboxint.xx < 1)
            {

                runingboxint.xx = 1;
                justforText3.Text3.color = Color.green;

             
            }
            else
            {
                runingboxint.xx = 0;
                justforText3.Text3.color = Color.red;
            }

        }
        if (sceneToChangeTo >= 2 & sceneToChangeTo <= 2)
        {
            justforText.Text1.color = Color.black;
            
            justforText3.Text3.color = Color.black;
            justforText4.Text4.color = Color.black;
            justforText5.Text5.color = Color.black;
            justforText6.Text6.color = Color.black;
            if (runingboxint.xx > 2 || runingboxint.xx < 2)
            {

                runingboxint.xx = 2;
                print("yes " + runingboxint.xx);
                justforText2.Text2.color = Color.green;
            }
            else
            {
                runingboxint.xx = -1;
                print("no " + runingboxint.xx);
                justforText2.Text2.color = Color.red;
            }

            //runingboxint.xx = 2;
            //justforText2.Text2.color = Color.blue;
        }

        if (sceneToChangeTo >= 3 & sceneToChangeTo <= 3)
        {
            
            justforText2.Text2.color = Color.black;
            justforText3.Text3.color = Color.black;
            justforText4.Text4.color = Color.black;
            justforText5.Text5.color = Color.black;
            justforText6.Text6.color = Color.black;

            if (runingboxint.xx >= 3 & runingboxint.xx <= 3)
            {

                runingboxint.xx = -2;
                print("no " + runingboxint.xx);
                justforText.Text1.color = Color.red;
            }
            else
            {
                runingboxint.xx = 3;
                print("yes " + runingboxint.xx);
                justforText.Text1.color = Color.green;//
            }
            //print ("functioning ");
        }
        if (sceneToChangeTo >= 4 & sceneToChangeTo <= 4)
        {
            justforText.Text1.color = Color.black;
            justforText2.Text2.color = Color.black;
            justforText3.Text3.color = Color.black;
            
            justforText5.Text5.color = Color.black;
            justforText6.Text6.color = Color.black;

            if (runingboxint.xx >= 4 & runingboxint.xx <= 4)
            {

                runingboxint.xx = -2;
                print("no " + runingboxint.xx);
                justforText4.Text4.color = Color.red;
            }
            else
            {
                runingboxint.xx = 4;
                print("yes " + runingboxint.xx);
                justforText4.Text4.color = Color.green;
            }
            //print ("functioning ");
        }
        if (sceneToChangeTo >= 5 & sceneToChangeTo <= 5)
        {
            justforText.Text1.color = Color.black;
            justforText2.Text2.color = Color.black;
            justforText3.Text3.color = Color.black;
            justforText4.Text4.color = Color.black;
            
            justforText6.Text6.color = Color.black;

            if (runingboxint.xx >= 5 & runingboxint.xx <= 5)
            {

               runingboxint.xx = -2; 
                print("no " + runingboxint.xx);
                justforText5.Text5.color = Color.red;
            }
            else
            {
                runingboxint.xx = 5;
                print("yes " + runingboxint.xx);
                justforText5.Text5.color = Color.green;
            }
        }

        if (sceneToChangeTo >= 6 & sceneToChangeTo <= 6)
        {
            justforText.Text1.color = Color.black;
            justforText2.Text2.color = Color.black;
            justforText3.Text3.color = Color.black;
            justforText4.Text4.color = Color.black;
            justforText5.Text5.color = Color.black;

            if (runingboxint.xx >= 6 & runingboxint.xx <= 6)
            {

                runingboxint.xx = -2;
                print("no " + runingboxint.xx);
                justforText6.Text6.color = Color.red;
            }
            else
            {
                runingboxint.xx = 6;
                print("yes " + runingboxint.xx);
                justforText6.Text6.color = Color.green;
            }
        }

        if (sceneToChangeTo >= 7 & sceneToChangeTo <= 7)
        {
            justforText.Text1.color = Color.black;
            justforText2.Text2.color = Color.black;
            justforText3.Text3.color = Color.black;
            justforText4.Text4.color = Color.black;
            justforText5.Text5.color = Color.black;
            justforText6.Text6.color = Color.black;

            runingboxint.number1 = 0;
            runingboxint.number2 = 0;
            runingboxint.number3 = 0;
            runingboxint.number4 = 0;
            runingboxint.number5 = 0;
            runingboxint.number6 = 0;
            //
            runingboxint.XYZ = runingboxint.XYZ + 1;
            //print(runingboxint.XYZ);
            


            KongregateAPI.SubmitData("HighScore", runingboxint.XYZ);
            //

        }

    }
}
//Application.LoadLevel(sceneToChangeTo);
/*for future refrence the background image was taken from pixabay a sight offering a colection of public domain images ( https: //pixabay.com/en/menger-fractal-design-cube-702863/ ) */
