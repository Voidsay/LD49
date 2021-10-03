using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public Transform respawnpoint;
    [SerializeField] SpecialGrav grav;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            collision.collider.transform.position = respawnpoint.position;
            collision.collider.transform.rotation = respawnpoint.rotation;
            grav.Reset(respawnpoint.up, respawnpoint.forward);
        }
    }
}
