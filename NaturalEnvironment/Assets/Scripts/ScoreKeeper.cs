using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour
{

    public Text VrInfo;
    public int count;
    public int displayTime;


    // Update is called once per frame
    void Update()
    {

        count++;

        if (count > displayTime)
        {

            count = 0;
            VrInfo.text = "";
        }
       

    }

    public void correctGuessMontana()
    {
        
        VrInfo.text = "Correct! Allosaurus fossils\n have been found\n in Montana.";

    }


    public void correctGuessPortugal()
    {

        VrInfo.text = "Correct! Allosaurus fossils\n have been found\n in Portugal.";



    }

    public void incorrectGuess()
    {

        VrInfo.text = "Nope not there! Try again! ";

    }
}