using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrencyConverter : MonoBehaviour {


    private static CurrencyConverter instance;
    public static CurrencyConverter Instance
    {
        get
        {
            return instance;
        }
    }

    void Awake()
    {
        CreateInstance();
    }

    void CreateInstance()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public string GetCurrencyIntoString(float valueToConvert, bool currencyPerSec, bool currencyPerClick)
    {
        string converted;
        if(valueToConvert >= 1000000)
        {
            converted = (valueToConvert / 1000000f).ToString("F3") + " M";
        }
        else if(valueToConvert >= 1000)
        {
            converted = (valueToConvert / 1000f).ToString ("F3") + " K";
        }
        else
        {
            converted = "" + valueToConvert.ToString("F0");
        }

        if(currencyPerSec == true)
        {
            converted = converted + " mps";
        }
        if(currencyPerClick == true)
        {
            converted = converted + " mpc";
        }
        return converted;
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
