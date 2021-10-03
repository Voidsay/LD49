using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialGrav : MonoBehaviour
{
    [SerializeField] LayerMask layer;
    [SerializeField] float rotSpeed;
    [SerializeField] CamControl contr;
    [SerializeField] Rigidbody rb;
    [SerializeField] float gravForce;

    Quaternion targetRotation;
    [SerializeField] Vector3 down;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        targetRotation *= contr.bodyRot;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, rotSpeed);
        rb.AddForce(down.normalized * gravForce, ForceMode.Acceleration);
    }

    void OnCollisionStay(Collision collision)
    {
        if ((1 << collision.gameObject.layer & layer.value) > 0)
        {
            down = collision.contacts[0].normal;
            var temp2 = Vector3.Angle(transform.forward, down);
            if (temp2 > 135)
            {
                targetRotation = Quaternion.LookRotation(-Vector3.Cross(Vector3.Cross(transform.up, down), down), down);
            }
            else if (temp2 < 45)
            {
                targetRotation = Quaternion.LookRotation(-Vector3.Cross(Vector3.Cross(-transform.up, down), down), down);
            }
            else
            {
                targetRotation = Quaternion.LookRotation(-Vector3.Cross(Vector3.Cross(transform.forward, down), down), down);
            }
        }
    }

    public void Reset(Vector3 up, Vector3 forward)
    {
        down = up;
        targetRotation = Quaternion.LookRotation(forward, up);
        Debug.Log(down + " " + transform.forward + " " + transform.forward);
    }

}
