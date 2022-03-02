using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject ball, cube, cup;
    [SerializeField] Material blue, green,red,white;
    public void ChnageCupColour(Material material)
    {
        cup.GetComponent<MeshRenderer>().material = material;
    }

    public void OnChangeToBlueButtonClick()
    {
        cube.GetComponent<MeshRenderer>().material = blue;
    }

    public void OnChangeToGreenButtonClick()
    {
        cube.GetComponent<MeshRenderer>().material = green;
    }

    public void OnGrabbleTouch()
    {
        Debug.Log("The user has touched the object");
        ball.GetComponent<MeshRenderer>().material = blue;
    }

    public void OnGrabbleTouchStop()
    {
        ball.GetComponent<MeshRenderer>().material = red;
    }

    public void OnGrabbleGrab()
    {
        Debug.Log("The user has grabbed the object");
        ball.GetComponent<MeshRenderer>().material = green;
    }

    public void OnGrabbleGrabStop()
    {
        ball.GetComponent<MeshRenderer>().material = red;
    }
}
