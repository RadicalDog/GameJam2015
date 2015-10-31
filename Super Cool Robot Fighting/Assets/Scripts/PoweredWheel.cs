using UnityEngine;
using System.Collections;

public class PoweredWheel : MonoBehaviour {

    public Rigidbody2D rigidBody;
    public float rotationSpeed;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rigidBody.AddTorque(rotationSpeed);
	}
}
