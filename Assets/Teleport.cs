using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            col.transform.position = target.transform.position;
            col.transform.rotation *= Quaternion.Euler(0, 180, 0);
            col.transform.rotation *= Quaternion.Euler(0, 0, 180);
        }
    }
}
