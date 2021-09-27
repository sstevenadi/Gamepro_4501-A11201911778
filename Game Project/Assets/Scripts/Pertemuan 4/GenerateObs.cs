using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateObs : MonoBehaviour
{
    public GameObject obstacle;

    public int score;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObs", 1f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CreateObs()
    {
        Instantiate(obstacle);
        score++;
    }

    private void OnGUI()
    {
        GUI.color = Color.black;
        GUILayout.Label("Score " + score.ToString());
    }
}
