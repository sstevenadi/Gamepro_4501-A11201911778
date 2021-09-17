using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotasiObject : MonoBehaviour
{
    public Vector3 maju;

    public Vector3 mundur;
    
    // Start is called before the first frame update
    void Start()
    {
        maju = new Vector3(0, 0, 1);
        mundur = new Vector3(0, 0, -1);
    }

    // Update is called once per frame
    void Update()
    {
        // transform.rotation = transform.rotation * toQuaternion(mundur * speedRotasi * Time.deltaTime);
    }
}
