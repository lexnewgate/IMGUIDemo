﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class App : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private string textFieldString = "text field";
    void OnGUI()
    {
        // Make a background box
        GUI.Box(new Rect(10, 10, 100, 90), "Loader Menu");

        // Make the first button. If it is pressed, Application.Loadlevel (1) will be executed
        if (GUI.Button(new Rect(20, 40, 80, 20), "Level 1"))
        {
            Debug.Log("button1");
        }

        // Make the second button.
        if (GUI.Button(new Rect(20, 70, 80, 20), "Level 2"))
        {
            Debug.Log("button2");
        }

        textFieldString = GUI.TextField(new Rect(200, 25, 100, 200), textFieldString);
        Debug.Log(textFieldString);

        GUILayout.Button("I am an Automatic Layout Button");

    }
}
