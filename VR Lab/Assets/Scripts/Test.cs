using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject ball;
    [SerializeField] Material blue, green,red;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My MINI VR Debugger!");
    }

    // Update is called once per frame
    void Update()
    {
        
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
