using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class OneSideSlice : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float PushForce;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision other)
    {
        Debug.Log(other.collider.tag + " / " + other.gameObject.tag);
        
        if (other.collider.CompareTag("Blade"))
        {
            _rigidbody.isKinematic = false;
            int pushSide = 1;
            if (transform.position.z < 0)
            {
                pushSide = -1;
            }
            Debug.Log("Add Force");
            
            Debug.Log(Vector3.forward * (pushSide * PushForce));
            _rigidbody.AddForce(Vector3.forward * (pushSide * PushForce), ForceMode.VelocityChange);
        }
    }
}
