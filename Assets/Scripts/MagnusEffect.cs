using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnusEffect : MonoBehaviour {

    public float magnusConst = 0.005f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate () {
        Vector3 force = magnusConst * Vector3.Cross(rb.velocity, rb.angularVelocity);
        rb.AddRelativeForce(force);
	}
}
