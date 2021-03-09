using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    private TextMeshProUGUI text;

    public static int scoreValue;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        scoreValue = 0;
    }

    void Update()
    {
        text.text = "Score: " + scoreValue.ToString();
    }
}
