using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public float speed;
    
    public int aksi;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (aksi) 
        {
            case 0:
                transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime);
                break;
            case 1:
                transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime);
                break;
            case 2:
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y);
                break;
            case 3:
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y);
                break;
        }
    }
}
