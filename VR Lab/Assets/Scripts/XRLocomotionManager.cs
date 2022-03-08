using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class XRLocomotionManager : MonoBehaviour
{
    [SerializeField] GameObject teleportLocomotion, continousLocomotion, walkInLocomotion;
    [SerializeField] LayerMask uIlayerMask, defaultLayerMask;
    [SerializeField] XRRayInteractor leftControllerRay, rightConotrllerRay;
    [SerializeField] XRInteractionManager xRInteractionManager;
    // Start is called before the first frame update
    void Start()
    {
        AcivateContinousLocomotion();
    }

    public void AcivateContinousLocomotion()
    {
        teleportLocomotion.SetActive(false);
        continousLocomotion.SetActive(true);
        walkInLocomotion.SetActive(false);
        leftControllerRay.raycastMask = uIlayerMask;
        rightConotrllerRay.raycastMask = uIlayerMask;
        xRInteractionManager.CheckToReActivateRauCastInteraction();
    }
    public void AcivateTeleportLocomotion()
    {
        teleportLocomotion.SetActive(true);
        continousLocomotion.SetActive(false);
        walkInLocomotion.SetActive(false);
        leftControllerRay.raycastMask = uIlayerMask + defaultLayerMask;
        rightConotrllerRay.raycastMask = uIlayerMask + defaultLayerMask;
        xRInteractionManager.CheckToReActivateRauCastInteraction();

    }
    public void AcivateWalkInPlaceLocomotion()
    {
        teleportLocomotion.SetActive(false);
        continousLocomotion.SetActive(false);
        walkInLocomotion.SetActive(true);
        leftControllerRay.raycastMask = uIlayerMask;
        rightConotrllerRay.raycastMask = uIlayerMask;
        xRInteractionManager.CheckToReActivateRauCastInteraction();
    }



}
