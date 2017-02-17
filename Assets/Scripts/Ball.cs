using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Rigidbody rb;
    private bool isHit = false;

    public float minSpeed = 2.5f;

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        if (isHit && rb.velocity.magnitude < minSpeed)
            Destroy(this.gameObject);
	}

    void OnCollisionEnter()
    {
        isHit = true;
    }
}
