using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour {

    public AudioClip bruhClip;
    public AudioSource bruhSource;
    public UnityEngine.UI.Text memeDisplay;
    public UnityEngine.UI.Text mpc;
    public float memes = 0.00f;
    public int memesPC = 1;

    private void Start()
    {
        bruhSource.clip = bruhClip;
    }

    // Update is called once per frame
    void Update () {
        memeDisplay.text = "mEmES: " + memes;
        mpc.text = "MPC: " + memesPC;
	}

    public void Clicked()
    {
        
        memes += memesPC;
        bruhSource.Play();



    }
}
