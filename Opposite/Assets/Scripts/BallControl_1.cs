using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl_1 : MonoBehaviour {


    private static float unit = 0.1F;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + unit, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - unit, transform.position.z);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector3(transform.position.x - unit, transform.position.y, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.RightArrow)){
            transform.position = new Vector3(transform.position.x + unit, transform.position.y, transform.position.z);

        }
    }

}
