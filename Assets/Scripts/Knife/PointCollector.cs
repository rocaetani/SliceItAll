using System;
using UnityEngine;
using UnityEngine.UI;

public class PointCollector : MonoBehaviour
{
    public GameObject GatherPointsPrefab;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("SliceableObject") && other.contacts[0].thisCollider.CompareTag("Blade") )
        {
            int points = other.gameObject.GetComponent<ObjectPoints>().Points;
            Debug.Log("Tocou no Sliceable");
            GameManager.Instance.PlayerPoints += points;
            GameObject gatherPrefabInstantiate = GatherPointsPrefab;
            gatherPrefabInstantiate.GetComponent<Text>().text = "+"+points;
            Instantiate(GatherPointsPrefab,Camera.current.WorldToScreenPoint(other.contacts[0].point), Quaternion.identity, MainCanvas.Instance.transform);
        }
    }
}
