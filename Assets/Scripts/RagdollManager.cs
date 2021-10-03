using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollManager : MonoBehaviour
{
    Rigidbody[] rbs;
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        rbs = GetComponentsInChildren<Rigidbody>();
        foreach (var rb in rbs)
        {
            rb.isKinematic = true;
        }
        anim.enabled = true;
    }

    public void Ragdoll()
    {
        foreach (var rb in rbs)
        {
            rb.isKinematic = false;
        }
        anim.enabled = false;
    }
}
