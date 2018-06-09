using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    Rigidbody2D playership;
    public float maxhorsepower;
    int engineStage = 0;
    float currenthorsepower;

    // Use this for initialization
    void Start () {
        playership = gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float speed = playership.velocity.magnitude;
        float steerTorque = speed / 2;
        if (steerTorque > 0.75)
            steerTorque = 0.75F;
        if (Input.GetKeyDown(KeyCode.W))
            engineStage++;
        else if (Input.GetKeyDown(KeyCode.S))
            engineStage--;
        if (engineStage >= 4)
        {
            engineStage = 4;
        }
        if (engineStage <= -1)
        {
            engineStage = -1;
        }
        playership.AddRelativeForce(Vector2.up * Power(engineStage));
        if (Input.GetKey(KeyCode.A))
        {
            playership.AddTorque(speed / 2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playership.AddTorque(-speed / 2);
        }
    }

    float Power(int ES)
    {
        if (ES == -1)
            currenthorsepower = maxhorsepower * -0.25F;
        if (ES == 0)
            currenthorsepower = maxhorsepower * 0;
        if (ES == 1)
            currenthorsepower = maxhorsepower * 0.25F;
        if (ES == 2)
            currenthorsepower = maxhorsepower * 0.5F;
        if (ES == 3)
            currenthorsepower = maxhorsepower * 0.75F;
        if (ES == 4)
            currenthorsepower = maxhorsepower;
        return currenthorsepower;
    }

}
