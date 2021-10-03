using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bloodEffect;
    [SerializeField] GameObject bulletImpactEffect;
    [SerializeField] float cooldowntime;
    [SerializeField] float flashtime;

    [SerializeField] GameObject flash;
    [SerializeField] AudioSource source;

    bool cooldown;

    public int ammo;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && !cooldown && !Options.opt.obj.gameObject.activeSelf)
        {
            if (Physics.Raycast(transform.position, transform.forward, out RaycastHit hit))
            {
                var temp = hit.collider.transform.root;
                if (temp.tag == "Enemy")
                {
                    Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
                    temp.GetComponent<Health>().Damage();
                }
                else
                {
                    Instantiate(bulletImpactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                }
            }
            cooldown = true;
            flash.SetActive(true);
            source.Play();
            ammo--;
            Invoke("Flash", flashtime);
            Invoke("Cool", cooldowntime);
        }
    }

    public void Cool()
    {
        cooldown = false;
    }

    public void Flash()
    {
        flash.SetActive(false);
    }
}
