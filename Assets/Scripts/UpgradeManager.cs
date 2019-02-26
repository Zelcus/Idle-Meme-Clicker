using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeManager : MonoBehaviour {

    public Click click;
    public UnityEngine.UI.Text itemInfo;
    public float cost;
    public int count;
    public int clickPower;
    public string itemName;
    private float _newCost;

    void Update()
    {
        itemInfo.text = itemName + "\nCost: " + cost + "\nMeme Power: +" + clickPower;
    }

    public void PurchasedUpgrade()
    {
        if(click.memes >= cost)
        {
            click.memes -= cost;
            count += 1;
            click.memesPC += clickPower;
            cost = Mathf.Round(cost * 1.15f);
            _newCost = Mathf.Pow(cost, _newCost = cost);
        }
    }
}
