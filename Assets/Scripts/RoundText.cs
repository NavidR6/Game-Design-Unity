using UnityEngine;
using TMPro;

public class RoundText : MonoBehaviour
{
    private TextMeshProUGUI text;

    public static int roundNumber;

    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
        roundNumber = 1;
    }

    void Update()
    {
        text.text = "Round " + roundNumber.ToString();
    }
}
