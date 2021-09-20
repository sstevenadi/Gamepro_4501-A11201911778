using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMove : MonoBehaviour
{

    public float speed;

    private Vector3 down;
    
    // Start is called before the first frame update
    void Start()
    {
        down = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (down * (speed * Time.deltaTime));
    }
}
