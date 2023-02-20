using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Change_color : MonoBehaviour
{
    public InputActionReference action;
    public new Light light;
    // Start is called before the first frame update
    void Start()
    {

        light = GetComponent<Light>();

        action.action.Enable();
        action.action.performed += (ctx) =>
        {

            light.color = Color.green;
        };



    }
}
