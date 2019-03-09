using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventManager : MonoBehaviour {

    public Click click;
    public int memesPC;
    public int memesPS;
    public Button button;
    public float cooldown;
    public float cooldownTemp;
    public float activeTimer;
    public float activeTimerTemp;
    public bool isClicked;
    public Text CooldownText;
    public Text ActiveText;

    void Awake()
    {
        cooldownTemp = 0;
        
    }
    void Update()
    {
        CooldownText.text = cooldownTemp.ToString("F0");
        ActiveText.text = activeTimerTemp.ToString("F0");
        if (cooldownTemp == 0)
        {
            ActiveText.gameObject.SetActive(false);
            CooldownText.gameObject.SetActive(false);
            GetComponent<Button>().interactable = true;
        }
        else
        {
            GetComponent<Button>().interactable = false;
        }

    }

    public void Activate()
    {
        if(cooldownTemp <= 0)
        {
            activeTimerTemp -= 1 * Time.deltaTime;
            
            ActiveText.gameObject.SetActive(true);
            CooldownText.gameObject.SetActive(false);
            if (activeTimerTemp == 0)
            {
                ActiveText.gameObject.SetActive(false);
                CooldownText.gameObject.SetActive(true);
                cooldownTemp -= 1 * Time.deltaTime;
            }
            activeTimerTemp = activeTimer;
            cooldownTemp = cooldown;
        }
        //memesPC = click.memesPC * memesPC;
        //memesPS = click.memesPS * memesPS;

        //    memesPC = click.memesPC;
        //    memesPS = click.memesPS;
           
        
    }
}
