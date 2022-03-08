using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputCapture : MonoBehaviour
{
    [Header("Select Action")]
    [SerializeField] InputActionReference rightControllerActionGrip;
    [SerializeField] InputActionReference leftControllerActionGrip;
    [Header("Activate Action")]
    [SerializeField] InputActionReference rightControllerActionTrigger;
    [SerializeField] InputActionReference leftControllerActionTrigger;
    [Header("Primary Button Action")]
    [SerializeField] InputActionReference rightPrimaryButtonAction;
    [SerializeField] InputActionReference leftPrimaryButtonAction;
    [Header("Secondary Button Action")]
    [SerializeField] InputActionReference rightSecondaryButtonAction;
    [SerializeField] InputActionReference leftSecondaryButtonAction;
    [Header("Turn (JoyStick) Action")]
    [SerializeField] InputActionReference rightTurnAction;
    [SerializeField] InputActionReference leftTurnAction;
    [Header("Primary 2D Axis Click Action (Joystick)")]
    [SerializeField] InputActionReference right2DAxisButton;
    [SerializeField] InputActionReference left2DAxisButton;
    [Header("Primary 2D Axis Touch Action (Joystick)")]
    [SerializeField] InputActionReference right2DAxisTouch;
    [SerializeField] InputActionReference left2DAxisTouch;

    [Header("My Actions")]
    [SerializeField] XRLocomotionManager xRLocomotionManager;
    [SerializeField] XRInteractionManager xRInteractionManager;

    private void Awake()
    {
        rightControllerActionGrip.action.performed += onRightGripPressed;
        leftControllerActionGrip.action.performed += onLeftGripPressed;

        rightControllerActionTrigger.action.performed += onRighTriggerPressed;
        leftControllerActionTrigger.action.performed += onLeftTriggerPressed;

        rightPrimaryButtonAction.action.performed += onRightControllerPrimaryButtonPressed;
        leftPrimaryButtonAction.action.performed += onLeftControllerPrimaryButtonPressed;

        rightSecondaryButtonAction.action.performed += onRightControllerSecondaryButtonPressed;
        leftSecondaryButtonAction.action.performed += onLeftControllerSecondaryButtonPressed;

        rightTurnAction.action.performed += onRightJoystickTurn;
        leftTurnAction.action.performed += onLeftJoystickTurn;

        right2DAxisButton.action.performed += onRight2DAxisButtonPressed;
        left2DAxisButton.action.performed += onLeft2DAxisButtonPressed;

        right2DAxisTouch.action.performed += onRight2DAxisTouchPressed;
        left2DAxisTouch.action.performed += onLeft2DAxisTouchPressed;
    }

    private void onRighTriggerPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Right Trigger Pressed.");
        //Debug.Log(obj.ReadValueAsButton());
        //Debug.Log(obj.ReadValue<float>());
    }
    private void onLeftTriggerPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Left Trigger Pressed.");
    }

    private void onRightGripPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Right Grip Pressed.");
    }

    private void onLeftGripPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Left Grip Pressed.");
    }

    private void onRightControllerPrimaryButtonPressed(InputAction.CallbackContext obj)
    {
        //Debug.Log("Right Primary Pressed (A).");
        xRLocomotionManager.AcivateContinousLocomotion();
    }

    private void onLeftControllerPrimaryButtonPressed(InputAction.CallbackContext obj)
    {
        //Debug.Log("Left Primary Pressed (X).");
        xRLocomotionManager.AcivateWalkInPlaceLocomotion();
    }

    private void onRightControllerSecondaryButtonPressed(InputAction.CallbackContext obj)
    {
        //Debug.Log("Right Secondary Pressed (B).");
        xRLocomotionManager.AcivateTeleportLocomotion();
    }

    private void onLeftControllerSecondaryButtonPressed(InputAction.CallbackContext obj)
    {
        //Debug.Log("Left Secondary Pressed (Y).");
        if (xRInteractionManager.isRayInteractionIsActive == true)
        {
            xRInteractionManager.DisableRayCastInteraction();
        } else
        {
            xRInteractionManager.ActivateRayCastInteraction();
        }
    }

    private void onRightJoystickTurn(InputAction.CallbackContext obj)
    {
        Debug.Log(obj.ReadValue<Vector2>());
    }
    private void onLeftJoystickTurn(InputAction.CallbackContext obj)
    {
        Debug.Log(obj.ReadValue<Vector2>());
    }

    private void onRight2DAxisButtonPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Right 2D Axis Pressed (Joystick).");
    }

    private void onLeft2DAxisButtonPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Left 2D Axis Pressed (Joystick).");
    }


    private void onRight2DAxisTouchPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Right 2D Axis Touched (Joystick).");
    }

    private void onLeft2DAxisTouchPressed(InputAction.CallbackContext obj)
    {
        Debug.Log("Left 2D Axis Touched (Joystick).");
    }

}
