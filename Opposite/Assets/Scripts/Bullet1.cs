using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet1 : MonoBehaviour {

    // Use this for initialization
    public GameObject SplitBullet1;
    private bool split;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Rigidbody2D>() != null && other.gameObject.CompareTag("Player2"))
        {
            other.transform.localScale = new Vector3(other.transform.localScale.x / 1.1f, other.transform.transform.localScale.y / 1.1f, other.transform.transform.localScale.z);
            Destroy(gameObject);
            Debug.Log(other.transform.localScale);
            BallControl_2.unit2 *= 1.25f;
            if (other.transform.localScale.x < 0.05)
                Destroy(other.gameObject);
        }
        if (!split && other.gameObject.GetComponent<Rigidbody2D>() != null && other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Rigidbody2D bl1 = Instantiate(SplitBullet1, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>();
            bl1.velocity = new Vector2(1, 0.44f);
            Rigidbody2D bl2 = Instantiate(SplitBullet1, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>();
            bl2.velocity = new Vector2(1, 0);
            Rigidbody2D bl3 = Instantiate(SplitBullet1, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>();
            bl3.velocity = new Vector2(1, -0.44f);
            split = true;
        }

    }
}
