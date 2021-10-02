using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSize : MonoBehaviour
{
    public Transform ObjectLeft;

    public Transform ObjectRight;

    public void ChangeSize(int size)
    {
        Vector3 newScale = ObjectLeft.localScale;
        newScale.z = size;
        ObjectLeft.localScale = newScale;
        ObjectRight.localScale = newScale;
        Vector3 newPosition = ObjectLeft.position;
        newPosition.z = size / 2f;
        ObjectLeft.position = newPosition;
        newPosition.z = newPosition.z * -1;
        ObjectRight.position = newPosition;
    }

}
