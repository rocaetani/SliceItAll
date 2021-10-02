using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int PlayerPoints;
    public Text PointsText;
    private void Awake()
    {
        Instance = this;
    }

    private void Update()
    {
        PointsText.text = "" + PlayerPoints;
    }

}
