﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {
	public Text text;

	// Use this for initialization
	void Start () {
		text.text = "Hello world!";
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return))
			text.text = "Get return!";
	}
}
