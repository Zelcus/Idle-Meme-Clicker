using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeManager : MonoBehaviour {

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count;
    public int clickPower;
    public string itemName;
    public Button button;
    private float baseCost;
    public string audioName;

    void Start()
    {
        baseCost = cost;
    }

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nClick Power: +" + clickPower;
        if (click.memes >= cost)
        {
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }
    }

    public void PurchasedUpgrade()
    {
        if (click.memes >= cost)
        {
            click.memes -= cost;
            count++;
            cost = Mathf.Round(baseCost * Mathf.Pow(1.15f, count));
            FindObjectOfType<AudioManager>().Play(audioName);
        }
        
    }
}
