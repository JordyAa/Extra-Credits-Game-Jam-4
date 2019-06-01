#pragma warning disable 0649
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance { get; private set; }
    
    [SerializeField] private TextMeshProUGUI facebookText;
    [SerializeField] private TextMeshProUGUI redditText;
    [SerializeField] private TextMeshProUGUI snapchatText;
    [SerializeField] private TextMeshProUGUI twitterText;

    private int facebookScore;
    private int redditScore;
    private int snapchatScore;
    private int twitterScore;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        LoadScore();
        UpdateScores();
    }

    public void AddScore(Platform platform, int amount=1)
    {
        switch (platform)
        {
            case Platform.Facebook:
                facebookScore += amount;
                break;
            
            case Platform.Reddit:
                redditScore += amount;
                break;
            
            case Platform.Snapchat:
                snapchatScore += amount;
                break;
            
            case Platform.Twitter:
                twitterScore += amount;
                break;
        }
        
        UpdateScores();
    }

    private void UpdateScores()
    {
        facebookText.text = facebookScore.ToString();
        redditText.text = redditScore.ToString();
        snapchatText.text = snapchatScore.ToString();
        twitterText.text = twitterScore.ToString();
    }

    private void LoadScore()
    {
        facebookScore = SaveController.facebookScore;
        redditScore = SaveController.redditScore;
        snapchatScore = SaveController.snapchatScore;
        twitterScore = SaveController.twitterScore;
    }

    public void SaveScore()
    {
        SaveController.facebookScore += facebookScore;
        SaveController.redditScore += redditScore;
        SaveController.snapchatScore += snapchatScore;
        SaveController.twitterScore += twitterScore;
    }
}
