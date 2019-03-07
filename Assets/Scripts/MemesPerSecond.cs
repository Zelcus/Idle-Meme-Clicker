using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemesPerSecond : MonoBehaviour {

    public UnityEngine.UI.Text mps;
    public Click click;
    public ItemManager[] items;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(AutoTick());
    }
    // Update is called once per frame
    void Update()
    {
        mps.text = GetMemesPerSecond() + " Memes / Second";
    }
    public float GetMemesPerSecond()
    {
        int tick = 0;
        foreach(ItemManager item in items)
        {
            tick += item.count * item.tickValue;
        }
        return tick;
    }
    public void AutoMemesPerSecond()
    {
        click.memes += GetMemesPerSecond() / 10;
    }

    IEnumerator AutoTick()
    {
        while(true)
        {
            AutoMemesPerSecond();
            yield return new WaitForSeconds(0.10f);
        }
    }

	

}
