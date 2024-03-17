using TMPro;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public static int Stars;
    public static int FirstJoin = 0;
    [SerializeField] private TextMeshProUGUI starsText;

    private void Start()
    {
        starsText.text = Stars.ToString();
    }
}
