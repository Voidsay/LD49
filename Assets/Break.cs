using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;

public class Break : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    bool fired;
    [SerializeField] bool end;

    [DllImport("__Internal")]
    private static extern int ConfirmMaker();
    [DllImport("__Internal")]
    private static extern int ConfirmMaker2();

    [SerializeField] string text, text1, text2;

    void OnCollisionEnter(Collision col)
    {
        if (col.collider.tag == "Player" && !fired)
        {
            fired = true;
            rb.isKinematic = false;
            if (end)
            {
                ConfirmMaker2();
                Application.Quit();
            }
            else
            {
                ConfirmMaker();
            }
        }
    }
}
