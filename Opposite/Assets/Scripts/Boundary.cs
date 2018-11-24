using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {

    // Use this for initialization
    public GameObject Bubble;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.L))
            LeftDraw();
        if (Input.GetKey(KeyCode.F))
            RightDraw();

    }

    void LeftDraw () {
        if (Random.Range(-1, 1) < -0.99)
            return;
        for (int i = 0; i < 1; i++)
        {
            Vector3 ps = new Vector3(transform.position.x, transform.position.y + Random.Range(-5, 5), transform.position.z - 1f);
            Rigidbody2D bl = Instantiate(Bubble, ps, Quaternion.identity).GetComponent<Rigidbody2D>();
            bl.velocity = new Vector2(-0.5f, 0);
        }
        transform.position = new Vector3(transform.position.x + 0.03f, transform.position.y, transform.position.z);

    }
    void RightDraw() {
        if (Random.Range(-1, 1) < -0.99)
            return;
        for (int i = 0; i < 1; i++)
        {
            Vector3 ps = new Vector3(transform.position.x, transform.position.y + Random.Range(-5, 5), transform.position.z - 1f);
            Rigidbody2D bl = Instantiate(Bubble, ps, Quaternion.identity).GetComponent<Rigidbody2D>();
            bl.velocity = new Vector2(0.5f, 0);
        }
        transform.position = new Vector3(transform.position.x - 0.03f, transform.position.y, transform.position.z);

    }
}
