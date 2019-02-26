using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    public AudioClip bruhClip;
    public AudioSource bruhSource;
    public UnityEngine.UI.Text memeDisplay;
    public int memes = 0;
    public int memesPC = 1;

    private void Start()
    {
        bruhSource.clip = bruhClip;
    }

    // Update is called once per frame
    void Update () {
        memeDisplay.text = "mEmES: " + memes; 
	}

    public void Clicked()
    {
        bruhSource.Play();
        memes += memesPC;
        
        
        
    }
}
