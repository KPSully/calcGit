using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input1 : MonoBehaviour {
    public calcBase.int eqValOne;
    InputField input;
	// Use this for initialization
	void Start () {
        eqValOne = int.Parse(input.text);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
