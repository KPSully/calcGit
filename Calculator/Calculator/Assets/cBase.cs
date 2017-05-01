using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cBase : MonoBehaviour
{
    public class equation
    {
        public string eqOperator;
        public int eqValOne;
        public int eqValTwo;
        public int eqOut;
        // Use this for initialization
        void Start()
        {
            eqOperator = "string";
            eqValOne = Convert.ToInt32(Console.ReadLine());
            eqValTwo = Convert.ToInt32(Console.ReadLine());
            eqOut = Convert.ToInt32(Console.ReadLine());
        }
        void Update()
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
                        eqOut = eqValOne * eqValTwo;
                        break;
                }
            }
        }

    }
}
