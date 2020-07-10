using TMPro;
using UnityEngine;

public class UILivesText : MonoBehaviour
{
    private TextMeshProUGUI tmproText;

    private void Awake()
    {
        tmproText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        GameManager.Instance.OnLivesChange += HandleOnLivesChange;
        tmproText.text = GameManager.Instance.Lives.ToString();
    }

    private void HandleOnLivesChange(int livesRemaining)
    {
        tmproText.text = livesRemaining.ToString();
    }

}
