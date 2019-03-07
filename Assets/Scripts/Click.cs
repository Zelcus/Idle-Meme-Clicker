using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Click : MonoBehaviour {

    public UnityEngine.UI.Text memeDisplay;
    public UnityEngine.UI.Text mpc;
    public UnityEngine.UI.Text mps;
    public float memes = 0.00f;
    public int memesPC = 1;
    public int memesPS = 0;
    public int clickCounter = 0;
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update () {

        memeDisplay.text = "Memes: " + CurrencyConverter.Instance.GetCurrencyIntoString(memes, false, false);   
        mpc.text = memesPC + " Memes / Click";
        mps.text = memesPS + " Memes / Second";

    }

    public void Clicked()
    {
        //Switch click is played every time you click in the center and bruh sound is played every 10 click as well as a extra memes. 
        FindObjectOfType<AudioManager>().Play("SwitchClick");
        if (clickCounter >= 10)
        {
            clickCounter = 0;
        }
        memes += memesPC;
  
        if(clickCounter == 0)
        {
            FindObjectOfType<AudioManager>().Play("ClickSound");
            memes += (memes * 0.05f);
        }
        clickCounter++;
    }

    public void IsopodHour()
    {

    }

    
}
