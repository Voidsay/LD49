using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class Popup : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern int PopupMaker(string text);

    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (PopupMaker("test") == 1)
            {
                obj.SetActive(true);
            }
        }
    }
}
