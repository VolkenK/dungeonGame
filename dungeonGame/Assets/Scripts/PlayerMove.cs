using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    private Rigidbody rigidBody;
    [SerializeField]private float speed = 1;

	// Use this for initialization
	void Start () {
        rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 force = new Vector3();
        force.x = Input.GetAxis("Horizontal");
        force.z = Input.GetAxis("Vertical");
        force *= speed;
        rigidBody.AddForce(force);
        
	}
}
