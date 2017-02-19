using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBack : MonoBehaviour {

    public Transform headset;
    public float comebackSpeed = 35f;

    void OnCollisionEnter()
    {
      Rigidbody rb = BallManager.instance.currentBall.GetComponent<Rigidbody>();
        rb.angularVelocity = Vector3.zero;
        Vector3 dir = (headset.position - rb.transform.position).normalized;
        rb.velocity = dir * comebackSpeed;
    }

}
