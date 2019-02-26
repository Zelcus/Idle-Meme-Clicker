using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    void Update () {
        memeDisplay.text = "mEmES: " + memes.ToString("F0");
        mpc.text = memesPC + " Memes / Click";
        
	}

    public void Clicked()
    {
        if (clickCounter >= 10)
        {
            clickCounter = 0;
        }
        memes += memesPC;
  
        if(clickCounter == 0)
        {
            FindObjectOfType<AudioManager>().Play("ClickSound");
            clickCounter++;
        }

        clickCounter++;



    }
}
