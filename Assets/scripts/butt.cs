using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class butt : MonoBehaviour {
    public static System.Random rand = new System.Random();
    ArrayList myArryList = new ArrayList();
    string guess = "";
    float t,E;
    public Text text0,text1, text2, text3, text4, text5, text6, text7, text8, text9, textvalue, begin, guesses, timers;
    panecontrol panel;
    public string pressed, msg4, key;
    string gusmsg, value;
    public bool timer;
    playercontrol player;
    // Use this for initialization
    void Start () {
        player = GameObject.FindObjectOfType<playercontrol>();
        gusmsg = "'A' when you get the numbers with there position ; 'B' when you only get the numbers.    \n";
        myArryList.Clear(); 
        t = 4;
        E = 300;
        begin.text = "Escape the Prison";
        panel = GameObject.FindObjectOfType<panecontrol>();
        key = generate();
        print(key);
	}
	
	// Update is called once per frame
	void Update () {

        textvalue.text = guess;
        t -= Time.deltaTime;
        if(t <= 0)
        {
            begin.text = "";
        }
        if(panel.msg == true & panel.msg2 == false)
        {
            begin.text = "press F to access the Keypad";
            
        }
        if(panel.msg == false & panel.msg2 == true)
        {
            begin.text = "RULES:- The moment you entered your first guess the timer will begin. "+
                "Information about your guess will be given to you every time you guess. "+
                "You can only input 4 numbers with out reapeating any."+
                "Press B to go back";
            
        }
        guesses.text = gusmsg;

        if(timer == true)
        {
            E -= Time.deltaTime;
            timers.text = E.ToString();

            if(E <= 0)
            {
#pragma warning disable CS0618 // Type or member is obsolete
                Application.LoadLevel("Loose");
#pragma warning restore CS0618 // Type or member is obsolete
            }
        }

        
    }

    public void press()
    {
        
        if(panel.msg3 == "B")
        {
            pressed = "A";
        }
        else
        {
            pressed = "F";
        }
    }

    public void one()
    {
        if (text1.text == "")
        {
            if (guess.Length < 4)
            {
                guess += "1";
                text1.text = "   ";
            }
            else if (guess.Length > 4)
            {
                text1.text = "   ";
            }
        }
    }

    public void two()
    {
        if (text2.text == "")
        {
            if (guess.Length < 4)
            {
                guess += "2";
                text2.text = "   ";
            }
            else if (guess.Length > 4)
            {
                text2.text = "   ";
            }
        }
    }

    public void three()
    {
        if (text3.text == "")
        {
            if (guess.Length < 4)
            {
                guess += "3";
                text3.text = "   ";
            }
            else if (guess.Length > 4)
            {
                text3.text = "   ";
            }
        }
    }
    public void four()
    {
        if (text4.text == "")
        {
            if (guess.Length < 4)
            {
                guess += "4";
                text4.text = "   ";
            }
            else if (guess.Length > 4)
            {
                text4.text = "   ";
            }
        }
    }
    public void five()
    {
        if (text5.text == "")
        {
            if (guess.Length < 4)
            {
                guess += "5";
                text5.text = "   ";
            }
            else if (guess.Length > 4)
            {
                text5.text = "   ";
            }
        }
    }
    public void six()
    {
        if (text6.text == "")
        {
            if (guess.Length < 4)
            {
                guess += "6";
                text6.text = "   ";
            }
            else if (guess.Length > 4)
            {
                text6.text = "   ";
            }
        }
    }
    public void seven()
    {
        if (text7.text == "")
        {
            if (guess.Length < 4)
            {
                guess += "7";
                text7.text = "   ";
            }
            else if (guess.Length > 4)
            {
                text7.text = "   ";
            }
        }
    }
    public void eight()
    {
        if (text8.text == "")
        {
            if (guess.Length < 4)
            {
                guess += "8";
                text8.text = "   ";
            }
            else if (guess.Length > 4)
            {
                text8.text = "   ";
            }
        }
    }
    public void nine()
    {
        if (text9.text == "")
        {
            if (guess.Length < 4)
            {
                guess += "9";
                text9.text = "   ";
            }
            else if (guess.Length > 4)
            {
                text9.text = "   ";
            }
        }
    }
    public void zero()
    {
        if (text0.text == "")
        {
            if (guess.Length < 4)
            {
                guess += "0";
                text0.text = "   ";
            }
            else if (guess.Length > 4)
            {
                text0.text = "   ";
            }
        }
    }

    public void CC()
    {
        guess = "";
        text0.text = "";
        text1.text = "";
        text2.text = "";
        text3.text = "";
        text4.text = "";
        text5.text = "";
        text6.text = "";
        text7.text = "";
        text8.text = "";
        text9.text = "";

    }

    public void check()
    {
        if(checkExistance(guess) == true)
        {
            gusmsg += "you already tried this number";
        }
        
        if (guess.Length < 4)
        {
            timer = false;
        }
        else if (guess == key)
        {
            msg4 = "correct";
            gusmsg +=" =>" +guess + "You got the key press B to go back";
            timer = false;
        }
        else if(guess != key)
        {
            timer = true;
            value = checkResult(guess, key);
            gusmsg = gusmsg+ " =>" + guess + " => " + value;
        }
        
    }
    public string generate()
    {

        int firstNumber, secondNumber, thirdNumber, fourthNumber;
        do
        {
            firstNumber = rand.Next(9);
            secondNumber = rand.Next(9);
            thirdNumber = rand.Next(9);
            fourthNumber = rand.Next(9);
        }
        while (firstNumber == secondNumber ||
        firstNumber == thirdNumber || firstNumber == fourthNumber ||
        secondNumber == thirdNumber ||
        secondNumber == fourthNumber || thirdNumber == fourthNumber);
        string a = firstNumber.ToString();
        string b = secondNumber.ToString();
        string c = thirdNumber.ToString();
        string d = fourthNumber.ToString();

        string generatedPin = a + b + c + d;
        return generatedPin;
    }

    public string checkResult(string guessedPin, string generatedPin)
    {
        //  CharSequence res = "";
        int acount = 0;
        int bcount = 0;
        //String a = b;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                if (guessedPin[i] == generatedPin[j])
                {
                    if (i == j)
                    {
                        // res = res + "A";
                        acount++;
                    }
                    else
                    {
                        // res = res + "B";
                        bcount++;
                    }
                }

            }
        }

        string processedResult = acount + " A " + bcount + " B ";
        return processedResult;

    }

    bool checkExistance(string guess)
    {

        if (myArryList.Contains(guess))
        {
            
            return true;
        }
        else
        {
            myArryList.Add(guess);
            return false;
        }


    }
}
