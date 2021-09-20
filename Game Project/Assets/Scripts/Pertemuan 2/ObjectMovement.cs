using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed;

    private Vector3 right;
    private Vector3 left;
    private Vector3 up;
    private Vector3 down;
    private Vector3 forward;
    private Vector3 backward;

    private int score;
    
    // Start is called before the first frame update
    void Start()
    {
        right = new Vector3(1, 0, 0);
        left = new Vector3(-1, 0, 0);
        up = new Vector3(0, 1, 0);
        down = new Vector3(0, -1, 0);
        forward = new Vector3(0, 0, 1);
        backward = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.position = transform.position + (right * (speed * Time.deltaTime));
        }
        
        if (Input.GetKey("left"))
        {
            transform.position = transform.position + (left * (speed * Time.deltaTime));
        }

        if (Input.GetKey("up"))
        {
            transform.position = transform.position + (up * (speed * Time.deltaTime));
        }

        if (Input.GetKey("down"))
        {
            transform.position = transform.position + (down * (speed * Time.deltaTime));
        }
        
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = transform.rotation * Quaternion.Euler(0, 0, (Time.deltaTime * 100));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = transform.rotation * Quaternion.Euler(0, 0, (-Time.deltaTime * 100));
        }

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("objEnemy"))
        {
            Debug.Log ("Game Over");
            Time.timeScale = 0;
        }

        if (other.gameObject.CompareTag("objCoin"))
        {
            score++;
            Destroy(other.gameObject);
            Debug.Log(score);
        }
    }

    /*
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("objEnemy"))
        {
            Debug.Log ("Lagi Nabrak");
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("objEnemy"))
        {
            Debug.Log ("Sudah Nabrak");
        }
    }
    */
    
}
