﻿using UnityEngine;
using System.Collections;

public class gun : MonoBehaviour {
	public GameObject bullet;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)){
			Instantiate (bullet,transform.position,Quaternion.Euler(Vector3.zero));
		}
	
	}
}
