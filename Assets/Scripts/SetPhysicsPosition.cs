using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPhysicsPosition : MonoBehaviour {

    private Rigidbody rb;

    public SteamVR_TrackedObject controller;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
        rb.MovePosition(controller.transform.position);
        rb.MoveRotation(controller.transform.rotation);
	}
}
