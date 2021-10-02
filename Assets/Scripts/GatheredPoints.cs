using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GatheredPoints : MonoBehaviour
{

    private Text _gatherText;
    private void Start()
    {
        _gatherText = GetComponent<Text>();
        StartCoroutine(nameof(Fade));

    }

    public void HideMessage()
    {
        _gatherText.enabled = false;
    }

    private IEnumerator Fade() 
    {
        Debug.Log("Entrou Fade");
        yield return new WaitForSeconds(.3f);
        for (float ft = 1f; ft >= 0; ft -= 0.1f)
        {
            Color c = _gatherText.color;
            c.a = ft;
            _gatherText.color = c;
            yield return new WaitForSeconds(.1f);
        }
        
        HideMessage();
        Color color = _gatherText.color;
        color.a = 1f;
        _gatherText.color = color;
        Destroy(gameObject);
        
    }
}
