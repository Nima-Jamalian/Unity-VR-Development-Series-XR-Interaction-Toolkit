using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarInputMapper : MonoBehaviour
{
    [Header("Avatar")]
    [SerializeField] Transform mainAvatarTransform;
    [SerializeField] Transform avatarHead;
    [SerializeField] Transform avatarBody;
    [Header("XR Rig")]
    [SerializeField] Transform XRHead;
    [Header("Offest")]
    [SerializeField] Vector3 headPositionOffset;
    // Update is called once per frame
    void Update()
    {
        mainAvatarTransform.position = Vector3.Lerp(mainAvatarTransform.position, XRHead.position + headPositionOffset, 0.5f);
        avatarHead.rotation = Quaternion.Lerp(avatarHead.rotation, XRHead.rotation, 0.5f);
        avatarBody.rotation = Quaternion.Lerp(avatarBody.rotation, Quaternion.Euler(new Vector3(0, avatarHead.rotation.eulerAngles.y, 0)), 0.05f);
    }
}
