using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreKeeper : MonoBehaviour
{

    public Text VrInfo;
    public int count;
    public int displayTime;
    public string correct;
    public string incorrect;

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

        VrInfo.text = correct;

    }


    public void correctGuessPortugal()
    {

        VrInfo.text = correct;



    }

    public void incorrectGuess()
    {

        VrInfo.text = incorrect;

    }
}