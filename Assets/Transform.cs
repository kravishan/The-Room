using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Transform : MonoBehaviour
{
    public InputActionReference actionReference;
    public Vector3 targetPosition;

    private InputAction action;

    private void OnEnable()
    {
        action = actionReference.action;
        action.performed += MoveToTarget;
    }

    private void OnDisable()
    {
        action.performed -= MoveToTarget;
    }

    private void MoveToTarget(InputAction.CallbackContext context)
    {
        transform.position = targetPosition;
    }
}