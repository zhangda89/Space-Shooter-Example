﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryByTime : MonoBehaviour {

	public float liftTime;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, liftTime);	
	}
}
