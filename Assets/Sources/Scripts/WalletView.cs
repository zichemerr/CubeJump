using TMPro;
using UnityEngine;

public class WalletView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    public void ShowDisplay(int value)
    {
        _scoreText.text = $"Монеточек: {value}";
    }
}
