using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {

   

    public GameObject Bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = new Vector3();
        if (Input.GetKey("North"))
        {
            direction.z += 1;

        }

    }
}
