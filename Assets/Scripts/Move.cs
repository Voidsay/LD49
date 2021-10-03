using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;
    [SerializeField] float jumpforce;
    [SerializeField] LayerMask layer;
    [SerializeField] float offset;

    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") + transform.right * Input.GetAxis("Horizontal")) * speed);
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            isGrounded = false;
            rb.AddForce(transform.up * jumpforce, ForceMode.Impulse);
        }
        var temp = Physics.OverlapSphere(transform.position + transform.up * offset, 0.1f);
        foreach (var tem in temp)
        {
            if ((1 << tem.gameObject.layer & layer.value) > 0)
            {
                isGrounded = true;
            }
        }
    }
}
