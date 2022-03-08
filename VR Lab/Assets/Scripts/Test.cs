using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject ball, cube, cup,capsule;
    [SerializeField] Material blue, green,red,white;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My MINI VR Debugger!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CapsuleChangeColour(Material material)
    {
        capsule.GetComponent<MeshRenderer>().material = material;
    }

    public void MakeCapsuleSmall()
    {
        capsule.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
    }

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
