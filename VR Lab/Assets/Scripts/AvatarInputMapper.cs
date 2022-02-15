using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarInputMapper : MonoBehaviour
{
   
    [SerializeField] Transform mainAvatarTransform, avatarHead, avatarBody;
    [SerializeField] Transform XRHead;

    [SerializeField] Vector3 headPositionOffset;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Converting the head position and rotation of the avatar to the XR head ration and position
        mainAvatarTransform.position = Vector3.Lerp(mainAvatarTransform.position, XRHead.position + headPositionOffset, 0.5f);
        avatarHead.rotation = Quaternion.Lerp(avatarHead.rotation, XRHead.rotation, 0.5f);
        avatarBody.rotation = Quaternion.Lerp(avatarBody.rotation, Quaternion.Euler(new Vector3(0, avatarHead.rotation.eulerAngles.y, 0)), 0.05f);
    }
}
