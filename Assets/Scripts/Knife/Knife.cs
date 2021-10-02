using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class Knife : MonoBehaviour
{
    private Rigidbody _rigidbody;

    public float Force;

    public float RotationForce;

    public Transform PushPosition;
    
    public Transform CenterOfMass;

    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        //_rigidbody.centerOfMass = CenterOfMass.position;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
        
            Vector3 newTarget = new Vector3(0.7f,1,0);
            _rigidbody.velocity = Vector3.zero;
            _rigidbody.AddForce(newTarget * Force, ForceMode.Impulse);
            
            _rigidbody.AddTorque(RotationForce * Vector3.back, ForceMode.Impulse);
        }

        if (transform.position.x > 150)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
