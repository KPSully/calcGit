using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calcBase : MonoBehaviour
{
    public string eqOperator;
    public int eqValOne;
    public int eqValTwo;
    public int eqOut;
    // Use this for initialization
    void Start()
    {
        {
            switch (eqOperator)
            {
                case ("/"):
                    eqOut = eqValOne / eqValTwo;
                    break;
                case ("+"):
                    eqOut = eqValOne + eqValTwo;
                    break;
                case ("-"):
                    eqOut = eqValOne - eqValTwo;
                    break;
                case ("*"):
                    eqOut = eqValOne - eqValTwo;
                    break;
            }
        }
    }

}

