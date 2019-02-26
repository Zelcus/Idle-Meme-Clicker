using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

    public UnityEngine.UI.Text itemInfo;
    public Click click;
    public float cost;
    public int tickValue;
    public int count;
    public string itemName;
    private float baseCost;
    public Button button;
    public string audioName;

    // Use this for initialization
	void Start () {
        baseCost = cost;	
	}
	
	// Update is called once per frame
	void Update () {
        itemInfo.text = itemName + "\nCost: " + cost + "\nMemes: " + tickValue + "/s";		
        if(click.memes >= cost)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }
	}

    public void PurchasedItem()
    {
        if(click.memes >= cost)
        {
            click.memes-= cost;
            count++;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
            FindObjectOfType<AudioManager>().Play(audioName);
        }
    }
}
