using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour {
    
    private float position;

	// Use this for initialization
	void Start () {

        position = transform.position.x;

    }
	
	// Update is called once per frame
	void Update () {

        position = position - 0.1f;
        transform.position = new Vector3(position, transform.position.y, transform.position.z);
        
        if(transform.position.x < -12.22f)
        {
            Destroy(gameObject);
        }
	}
}
