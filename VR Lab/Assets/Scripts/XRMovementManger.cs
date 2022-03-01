using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class XRMovementManger : MonoBehaviour
{
    [SerializeField] XRRayInteractor leftHandControllerRay, rightHandControllerRay;
    [SerializeField] LayerMask UIlayerMask,defaultLayerMask;
    [SerializeField] GameObject locomotionMovementSystem, continuousMovementSystem, walkInPlaceMovementSystem;
    public void Start()
    {
        //Set the default movement to continuous movement
        ActivateContinousMovement();
    }
    public void ActivateContinousMovement()
    {
        continuousMovementSystem.SetActive(true);
        locomotionMovementSystem.SetActive(false);
        walkInPlaceMovementSystem.SetActive(false);
        leftHandControllerRay.raycastMask = UIlayerMask;
        rightHandControllerRay.raycastMask = UIlayerMask;
    }

    public void ActivateLocomotionMovement()
    {
        continuousMovementSystem.SetActive(false);
        locomotionMovementSystem.SetActive(true);
        walkInPlaceMovementSystem.SetActive(false);
        leftHandControllerRay.raycastMask = defaultLayerMask + UIlayerMask;
        rightHandControllerRay.raycastMask = defaultLayerMask + UIlayerMask;
    }

    public void ActivateWalkInPlaceMovement()
    {
        continuousMovementSystem.SetActive(false);
        locomotionMovementSystem.SetActive(false);
        walkInPlaceMovementSystem.SetActive(true);
        leftHandControllerRay.raycastMask = UIlayerMask;
        rightHandControllerRay.raycastMask = UIlayerMask;
    }
}
