using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input1 : MonoBehaviour
{

    InputField input;
    public cBase.equation eqValOne;
  //   Use this for initialization
    public void FirstVal()
   {
        eqValOne = Parse(input.text);
    }

    private cBase.equation Parse(string text)
    {
        throw new NotImplementedException();
    }
}