using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl_1 : MonoBehaviour
{


    public float unit = 0.1f;
    private Dictionary<int, int> bubbles = new Dictionary<int, int>();
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + unit, transform.position.y, transform.position.z);

        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<Rigidbody2D>() != null && !bubbles.ContainsKey(other.GetInstanceID()))
        {
            bubbles[other.GetInstanceID()] = 1;
            //other.transform.SetParent(transform, false);
            transform.localScale = new Vector3(transform.localScale.x * 1.1f, transform.localScale.y * 1.1f, transform.localScale.z);
            unit *= 0.8f;
            Destroy(other.gameObject);
            Debug.Log("!");
        }

    }
}
