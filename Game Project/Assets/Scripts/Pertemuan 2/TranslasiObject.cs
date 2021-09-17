using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslasiObject : MonoBehaviour
{
    public Vector3 kekanan;
    public Vector3 kekiri;
    public Vector3 keatas;
    public Vector3 kebawah;
    // Start is called before the first frame update
    void Start()
    {
        kekanan = new Vector3(1, 0, 0);
        kekiri = new Vector3(-1, 0, 0);
        keatas = new Vector3(0, 1, 0);
        kebawah = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // transform.position = transform.position + (kekanan * speed * Time.deltaTime);
        // transform.position = transform.position + (kekiri * speed * Time.deltaTime);
        // transform.position = transform.position + (keatas * speed * Time.deltaTime);
        // transform.position = transform.position + (kebawah * speed * Time.deltaTime);

    }
}
