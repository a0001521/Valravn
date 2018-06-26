using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour {
    public float speed = 0.75f;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 mouseDir = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position; //This line accquires the mouse position relative to the object.
        float angle = (Mathf.Atan2(mouseDir.y, mouseDir.x) * Mathf.Rad2Deg) + 270; //This line converts the data into degrees
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed);
	}
}
