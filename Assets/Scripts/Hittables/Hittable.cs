#pragma warning disable 0649
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Hittable : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI messageText;

    [SerializeField] private Sprite facebookSprite;
    [SerializeField] private Sprite redditSprite;
    [SerializeField] private Sprite snapchatSprite;
    [SerializeField] private Sprite twitterSprite;
    
    private TextBox _textBox;
    public TextBox textBox
    {
        get => _textBox;
        set
        {
            _textBox = value;
            SetText();
            SetSprite();
        }
    }

    private void SetText()
    {
        nameText.text = ResourcesManager.instance.names[
            Random.Range(0, ResourcesManager.instance.names.Length)];
        
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

    private void SetSprite()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        
        switch (textBox.platform)
        {
            case Platform.Facebook:
                sr.sprite = facebookSprite;
                break;
            case Platform.Reddit:
                sr.sprite = redditSprite;
                break;
            case Platform.Snapchat:
                sr.sprite = snapchatSprite;
                break;
            case Platform.Twitter:
                sr.sprite = twitterSprite;
                break;
        }
    }

    public void OnHit()
    {
        if (textBox.isPositive)
        {
            ScoreManager.instance.AddScore(textBox.platform);
        }
        else
        {
            // todo: Game Over
        }
        
        PlayerManager.instance.RemoveFromFearSetter(gameObject);
        Destroy(gameObject);
    }
}
