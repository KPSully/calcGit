using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input1 : MonoBehaviour
{
    private InputField input;
    cBase.equation eqValOne;
    //   Use this for initialization
    public void FirstVal()
    {
        int eqValOne = Convert.ToInt32(input.text);
    }
}