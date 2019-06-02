using UnityEngine;

public class UpgradeManager : MonoBehaviour
{
    public void PurchasePositiveBonus(int platform)
    {
        switch (platform)
        {
            case 0:
                if (SaveController.facebookScore >= 10)
                {
                    SaveController.facebookScore -= 10;
                    UpgradeController.facebookPositiveBonus += 0.05f;
                }
                
                break;
            
            case 1:
                if (SaveController.redditScore >= 10)
                {
                    SaveController.redditScore -= 10;
                    UpgradeController.redditPositiveBonus += 0.05f;
                }

                break;
            
            case 2:
                if (SaveController.snapchatScore >= 10)
                {
                    SaveController.snapchatScore -= 10;
                    UpgradeController.snapchatPositiveBonus += 0.05f;
                }
                
                break;
            
            case 3:
                if (SaveController.twitterScore >= 10)
                {
                    SaveController.twitterScore -= 10;
                    UpgradeController.twitterPositiveBonus += 0.05f;
                }
                
                break;
        }
        
        ScoreManager.instance.UpdateScores();
    }
    
    public void PurchaseScoreAmount(int platform)
    {
        switch (platform)
        {
            case 0:
                if (SaveController.facebookScore >= 20)
                {
                    SaveController.facebookScore -= 20;
                    UpgradeController.facebookScoreAmount += 1;
                }
                
                break;
            
            case 1:
                if (SaveController.redditScore >= 20)
                {
                    SaveController.redditScore -= 20;
                    UpgradeController.redditScoreAmount += 1;
                }

                break;
            
            case 2:
                if (SaveController.snapchatScore >= 20)
                {
                    SaveController.snapchatScore -= 20;
                    UpgradeController.snapchatScoreAmount += 1;
                }
                
                break;
            
            case 3:
                if (SaveController.twitterScore >= 20)
                {
                    SaveController.twitterScore -= 20;
                    UpgradeController.twitterScoreAmount += 1;
                }
                
                break;
        }
        
        ScoreManager.instance.UpdateScores();
    }
}
