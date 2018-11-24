using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl_2 : MonoBehaviour {


    private static float unit = 0.1F;

    private Vector2 move;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + unit, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - unit, transform.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - unit, transform.position.y, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + unit, transform.position.y, transform.position.z);

        }
    }
}
