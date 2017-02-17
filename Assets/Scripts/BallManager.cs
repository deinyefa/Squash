using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {

    public GameObject ballPrefab;

    private GameObject currentBall;

    void Start () {
		
	}
	
	void Update () {
        if (currentBall == null)
            currentBall = Instantiate(ballPrefab, transform.position, transform.rotation) as GameObject;
	}
}
