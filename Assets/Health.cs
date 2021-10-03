using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int _health;
    [SerializeField] RagdollManager manager;
    [SerializeField] AudioSource source;
    [SerializeField] AudioSource grunt;
    [SerializeField] AudioClip[] grunts;

    public int health
    {
        get
        {
            return _health;
        }
        private set
        {
            _health = value;
            if (_health <= 0)
            {
                Die();
            }
        }
    }

    public void Damage()
    {
        health--;
        grunt.PlayOneShot(grunts[Random.Range(0, grunts.Length)]);
    }

    void Die()
    {
        manager.Ragdoll();
        source.loop = false;
        source.Stop();
    }
}
