using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputCapture : MonoBehaviour
{
    [Header("Select Action")]
    [SerializeField] InputActionReference rightControllerGrip, leftControllerGrip;

    [SerializeField] InputActionReference rightPrimaryButton, leftPrimayButton;
    private void Awake()
    {
        rightControllerGrip.action.performed += onRightGripPressed;
        leftControllerGrip.action.performed += onLeftGripPressed;
        rightPrimaryButton.action.performed += onRightPrimayButtonPressed;
        leftPrimayButton.action.performed += onLeftPrimayButtonPressed;
    }

    void onRightGripPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Right Grip Pressed");
    }

    void onLeftGripPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Left Grip Pressed");
    }

    void onRightPrimayButtonPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("A Pressed");
    }

    void onLeftPrimayButtonPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("X Pressed");
    }
}
