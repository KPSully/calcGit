using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class calcBase: MonoBehaviour 
{
    public string eqOperator;
    public int eqValOne;
    public int eqValTwo;
    public int eqOut;
    InputField input;
    GameObject field;
    void Start()
    {
        eqOperator = "+";
        eqValOne = 0;
        eqValTwo = 0;
       // input = gameObject.GetComponent<InputField>();
    }
    public void FirstVal()
    {
        gameObject
        int eqValOne = Convert.ToInt32(input.text);
    }
    public void SecVal()
    {
            int eqValTwo = Convert.ToInt32(input.text);
    }
    public void Operator()
    {
        eqOperator = "/";
    }
    public void Update() 
    {
        if (Input.GetKey(KeyCode.Return))
        {
            print(eqOut);
        }
            switch (eqOperator) 
        {
            case "/":
                eqOut = eqValOne / eqValTwo;
                break;
            case "+":
                eqOut = eqValOne + eqValTwo;
                break;
            case "-":
                eqOut = eqValOne - eqValTwo;
                break;
            case "*":
                eqOut = eqValOne * eqValTwo;
                break;
        }
    }
} 