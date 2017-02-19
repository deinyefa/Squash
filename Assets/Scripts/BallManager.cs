using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour {

    public static BallManager instance;
    public GameObject ballPrefab;

    [HideInInspector]
    public GameObject currentBall;

    void Awake () {
        if (instance == null)
            instance = this;
	}

    void OnDestroy ()
    {
        if (instance == this)
            instance = null;
    }

    void Update () {
        if (currentBall == null)
            currentBall = Instantiate(ballPrefab, transform.position, transform.rotation) as GameObject;
	}
}
