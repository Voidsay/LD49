using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public float sensX, sensY;
    public GameObject obj;

    public static Options opt;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        opt = this;
    }

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            obj.SetActive(!obj.activeSelf);
            if (obj.activeSelf)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
            else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
        }
    }

    public void setX(string x)
    {
        try
        {
            sensX = float.Parse(x);
        }
        catch
        {
            Debug.LogWarning("invalid float");
        }
    }

    public void setY(string x)
    {
        try
        {
            sensY = float.Parse(x);
        }
        catch
        {
            Debug.LogWarning("invalid float");
        }
    }
}
