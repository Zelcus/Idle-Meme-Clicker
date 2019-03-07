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
        if (click.memes >= cost && count == 0)
        {
            GetComponent<Button>().interactable = true;
        }
        else if(count != 0)
        {
            itemInfo.text = itemName + "\nIs already purchased!";
            GetComponent<Button>().interactable = false;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }
    }

    public void PurchasedUpgrade()
    {
        if (click.memes >= cost && count == 0)
        {
            click.memes -= cost;         
            click.memesPC += clickPower;
            FindObjectOfType<AudioManager>().Play(audioName);
            count++;
        }
        
    }
}
