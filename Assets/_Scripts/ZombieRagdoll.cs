using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieRagdoll : MonoBehaviour
{
    private Collider[] colliders;
    private Rigidbody[] rigibodies;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        colliders = GetComponentsInChildren<Collider>();
        rigibodies = GetComponentsInChildren<Rigidbody>();

        DisableRagdoll();
    }

    private void DisableRagdoll()
    {
        anim.enabled = true;
        for (var i = 0; i < colliders.Length; i++)
        {
            colliders[i].isTrigger = true;
            rigibodies[i].isKinematic = true;
        }
    }

    private void EnableRagdoll()
    {
        anim.enabled = false;
        for (var i = 0; i < colliders.Length; i++)
        {
            colliders[i].isTrigger = false;
            rigibodies[i].isKinematic = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            EnableRagdoll();
        }
    }
}
