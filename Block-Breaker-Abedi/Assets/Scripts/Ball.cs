using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    private Paddle paddle;

    private Vector3 distanceBetweenBallAndPaddle;
    private bool hasStarted = false;
	// Use this for initialization
	void Start () {
        paddle = FindObjectOfType<Paddle>();
        distanceBetweenBallAndPaddle =this.transform.position - paddle.transform.position;
        
	}
	
	// Update is called once per frame
	void Update () {
        if(!hasStarted)
        this.transform.position = paddle.transform.position + distanceBetweenBallAndPaddle;
        if (Input.GetMouseButtonDown(0))
        {
            hasStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }

    }
   
}
