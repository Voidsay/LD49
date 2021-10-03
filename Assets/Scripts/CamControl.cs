using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    [SerializeField] Transform cam;
    public Quaternion bodyRot;
    [SerializeField] Options opt;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!Options.opt.obj.gameObject.activeSelf)
        {
            bodyRot = Quaternion.Euler(0, Input.GetAxis("Mouse X") * Options.opt.sensX, 0);
            transform.rotation *= bodyRot;
            var temp = cam.rotation;
            cam.rotation *= Quaternion.Euler(Input.GetAxis("Mouse Y") * Options.opt.sensY, 0, 0);
            if (Vector3.Angle(transform.forward, cam.forward) > 90)
            {
                cam.rotation = temp;
            }
        }
    }
}
