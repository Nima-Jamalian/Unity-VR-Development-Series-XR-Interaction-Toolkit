using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class HingeJointListener : MonoBehaviour
{
    private HingeJoint hingeJoint;
    [SerializeField] float doorOpenAngle = 1f;

    [SerializeField] hingeJoingDefaultSate hingeJoingDefault = hingeJoingDefaultSate.closed;
    enum hingeJoingDefaultSate {open,closed}
    bool isDoorOpen, isDoorClosed = false;

    [SerializeField] UnityEvent OnDoorOpenEvent;
    [SerializeField] UnityEvent OnDoorClosedEvent;
    // Start is called before the first frame update
    void Start()
    {
        hingeJoint = GetComponent<HingeJoint>();
        if(hingeJoingDefault == hingeJoingDefaultSate.closed)
        {
            isDoorClosed = true;
        }
    }

    private void FixedUpdate()
    {
        //Debug.Log(hingeJoint.angle);

        if (hingeJoint.angle > doorOpenAngle) //door has been open
        {
            if(isDoorOpen == false)
            {
                //Debug.Log("DoorOpen");
                OnDoorOpenEvent.Invoke();
                isDoorOpen = true;
                isDoorClosed = false;
            }

        }
        else if (hingeJoint.angle < doorOpenAngle)//door has been closed
        {
            if(isDoorClosed == false)
            {
                //Debug.Log("DoorClosed");
                OnDoorClosedEvent.Invoke();
                isDoorClosed = true;
                isDoorOpen = false;
            }
        }
    }
}
