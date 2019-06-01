#pragma warning disable 0649
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class HittableText : MonoBehaviour, IHittable
{
    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI messageText;

    [SerializeField] private Sprite facebookSprite;
    [SerializeField] private Sprite redditSprite;
    [SerializeField] private Sprite snapchatSprite;
    [SerializeField] private Sprite twitterSprite;
    
    [SerializeField] private GameObject destroyEffect;
    
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

        messageText.text = textBox.isPositive
            ? ResourcesManager.instance.messagesPositive[
                Random.Range(0, ResourcesManager.instance.messagesPositive.Length)]
            : ResourcesManager.instance.messagesNegative[
                Random.Range(0, ResourcesManager.instance.messagesNegative.Length)];
    }

    private void SetSprite()
    {
        GetComponent<SpriteRenderer>().sprite =
            textBox.platform == Platform.Facebook ? facebookSprite :
            textBox.platform == Platform.Reddit ? redditSprite :
            textBox.platform == Platform.Snapchat ? snapchatSprite :
            twitterSprite;
    }

    public void OnHit()
    {
        if (textBox.isPositive)
        {
            ScoreManager.instance.AddScore(textBox.platform);
        }
        else
        {
            GameOverManager.instance.gameOver = true;
        }
        
        // Instantiate(destroyEffect, transform.position, Quaternion.identity);
        
        PlayerManager.instance.RemoveFromFearSetter(gameObject);
        Destroy(gameObject);
    }
}
