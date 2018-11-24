using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl_2 : MonoBehaviour {

    public GameObject Bullet;
    public static float unit2 = 0.1f;
    //private Vector2 move;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update(){
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + unit2, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - unit2, transform.position.z);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector3(transform.position.x - unit2, transform.position.y, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector3(transform.position.x + unit2, transform.position.y, transform.position.z);

        }
        if (Input.GetKey(KeyCode.G) && transform.localScale.x > 0.05f)
        {
            Rigidbody2D bl = Instantiate(Bullet, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>();
            bl.velocity = new Vector2(-1, 0);
            transform.localScale = new Vector3(transform.localScale.x / 1.1f, transform.localScale.y / 1.1f, transform.localScale.z);
            Debug.Log(transform.localScale);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Rigidbody2D>() != null && other.gameObject.CompareTag("Bullet"))
        {
            //bubbles[other.GetInstanceID()] = 1;
            //other.transform.SetParent(transform, false);
            transform.localScale = new Vector3(transform.localScale.x * 1.1f, transform.localScale.y * 1.1f, transform.localScale.z);
            unit2 *= 0.8f;
            Destroy(other.gameObject);
            Debug.Log("!");
        }

    }

}
