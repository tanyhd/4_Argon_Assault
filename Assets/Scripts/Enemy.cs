﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    [SerializeField] GameObject explosionVFX;
	// Use this for initialization
	void Start () {
        AddNonTriggerBoxCollider();
	}

    private void AddNonTriggerBoxCollider()
    {
        Collider boxCollider = gameObject.AddComponent<BoxCollider>();
        boxCollider.isTrigger = false;
    }

    // Update is called once per frame
    void Update () {
		
	}

    private void OnParticleCollision(GameObject other)
    {
        Instantiate(explosionVFX, transform.localPosition, Quaternion.identity);
        print("Hit by bullets");
        Destroy(gameObject);
    }
}
