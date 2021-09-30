using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Collections;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class Knife : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float Force;

    public float RotationForce;

    public Transform PushPosition;
    
    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
        
            Debug.Log("Aplicou forca");
            Vector3 newTarget = new Vector3(0.5f,1,0);
            _rigidbody.velocity = Vector3.zero;
            //_rigidbody.AddForceAtPosition(newTarget * Force, PushPosition.position, ForceMode.Impulse);
            _rigidbody.AddForce(newTarget * Force, ForceMode.Impulse);
            
            _rigidbody.AddTorque(RotationForce * Vector3.back);
            
        }
        
    }
}
