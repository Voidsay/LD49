using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ammodisplay : MonoBehaviour
{
    [SerializeField] Shoot shoot;
    [SerializeField] Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = shoot.ammo.ToString();
    }
}
