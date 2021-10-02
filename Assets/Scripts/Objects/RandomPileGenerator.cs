using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPileGenerator : MonoBehaviour
{

    public GameObject SlicedObjectPrefab;

    public int PileSize;

    public int initY;
    // Start is called before the first frame update
    void Awake()
    {
        for (int i = 0; i < PileSize; i++)
        {
            GameObject newBlock = Instantiate(SlicedObjectPrefab, transform.position, Quaternion.identity);
            ObjectSize newBlockSize = newBlock.GetComponent<ObjectSize>();
            newBlockSize.ChangeSize(Random.Range(1,5));
            Vector3 newPosition = newBlock.transform.position;
            newPosition.y = initY + i;
            newBlock.transform.position = newPosition;
        }
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }
}
