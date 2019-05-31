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
        if (textBox.isPositive)
        {
            messageText.text = ResourcesManager.instance.messagesPositive[
                Random.Range(0, ResourcesManager.instance.messagesPositive.Length)];
        }
        else
        {
            messageText.text = ResourcesManager.instance.messagesNegative[
                Random.Range(0, ResourcesManager.instance.messagesNegative.Length)];
        }
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
