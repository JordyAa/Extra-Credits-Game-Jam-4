#pragma warning disable 0649
using TMPro;
using UnityEngine;

public class Hittable : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI messageText;
    
    private TextBox _textBox;
    public TextBox textBox
    {
        get => _textBox;
        set
        {
            _textBox = value;
            SetText();
        }
    }

    private void SetText()
    {
        messageText.text = textBox.text;
    }

    public void OnHit()
    {
        if (textBox.isPositive)
        {
            ScoreManager.instance.AddScore(textBox.platform);
            PlayerManager.instance.RemoveFromFearSetter(gameObject);
            Destroy(gameObject);
        }
    }
}
