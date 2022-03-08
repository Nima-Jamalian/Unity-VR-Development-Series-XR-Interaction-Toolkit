using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
public class XRInteractionManager : MonoBehaviour
{
    [SerializeField] LayerMask grabbleLayerMask;
    [SerializeField] XRRayInteractor leftControllerRay, rightConotrllerRay;
    [SerializeField] XRInteractorLineVisual leftRayVisual, rightRayVisual;
    [SerializeField] Gradient invalidGradientColor, invisibleGradientColor;
    public bool isRayInteractionIsActive = false;
    public void ActivateRayCastInteraction()
    {
        leftControllerRay.raycastMask += grabbleLayerMask;
        rightConotrllerRay.raycastMask += grabbleLayerMask;
        leftRayVisual.invalidColorGradient = invalidGradientColor;
        rightRayVisual.invalidColorGradient = invalidGradientColor;
        isRayInteractionIsActive = true;
    }

    public void DisableRayCastInteraction()
    {
        leftControllerRay.raycastMask -= grabbleLayerMask;
        rightConotrllerRay.raycastMask -= grabbleLayerMask;
        leftRayVisual.invalidColorGradient = invisibleGradientColor;
        rightRayVisual.invalidColorGradient = invisibleGradientColor;
        isRayInteractionIsActive = false;
    }

    public void CheckToReActivateRauCastInteraction()
    {
        if(isRayInteractionIsActive == true)
        {
            ActivateRayCastInteraction();
        }
    }
}
