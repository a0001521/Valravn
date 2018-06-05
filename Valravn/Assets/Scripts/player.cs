using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    Rigidbody2D playership;
    public float horsepower;
    Vector2 steeringpower;
	// Use this for initialization
	void Start () {
        playership = gameObject.GetComponent<Rigidbody2D>();
        steeringpower = new Vector2(0.0F, 1.0F);
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
            playership.AddRelativeForce(steeringpower * horsepower);
        if (Input.GetKey(KeyCode.S))
            playership.AddRelativeForce(Vector2.down * horsepower);
        if (Input.GetKey(KeyCode.A))
            playership.AddTorque(1);
        if (Input.GetKey(KeyCode.D))
            playership.AddTorque(-1);
    }
}
