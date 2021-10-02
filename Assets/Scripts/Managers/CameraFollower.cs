using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{

    public Vector3 CameraPosition;
    public Transform Followed;
    

    // Update is called once per frame
    void Update()
    {
        transform.position = Followed.position + CameraPosition;
    }
}
