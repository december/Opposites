using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitBullet2:MonoBehaviour {

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Rigidbody2D>() != null && other.gameObject.CompareTag("Player1"))
        {
            other.transform.localScale = new Vector3(other.transform.localScale.x / 1.1f, other.transform.localScale.y / 1.1f, other.transform.localScale.z);
            Destroy(gameObject);
            BallControl_1.unit1 *= 1.25f;
            if (other.transform.localScale.x < 0.05)
                Destroy(other.gameObject);
            //Debug.Log("!");
        }

    }
}
