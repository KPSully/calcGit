using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cBase: MonoBehaviour 
{
    public string eqOperator;
    public int eqValOne;
    public int eqValTwo;
    public int eqOut;
    InputField input;

    void FirstVal()
    {
        int eqValOne = Convert.ToInt32(input.text);
    }
    void SecVal()
    {
        int eqValTwo = Convert.ToInt32(input.text);
    }
    void Operator()
    {
        eqOperator = "/";
    }
    void Update() 
    {
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