﻿using UnityEngine;
using System.Collections;

public class CreateTactileObstacle : MonoBehaviour {

    public Vector3 scale;

    private Transform rumblePickup;

	// Use this for initialization
	void Start () {
        transform.localScale = scale;
        rumblePickup = transform.GetChild(0);
        rumblePickup.localScale = new Vector3(transform.localScale.x / transform.localScale.x, transform.localScale.y / transform.localScale.y, transform.localScale.z / transform.localScale.z / 100.0f);
        rumblePickup.localPosition = new Vector3(0.0f, 0.0f, (transform.localScale.z / 2.0f / transform.localScale.z) - (rumblePickup.localScale.z * 5.0f / 10.0f));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}