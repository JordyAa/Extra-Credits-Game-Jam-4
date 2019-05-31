using UnityEngine;

public class Hittable : MonoBehaviour
{
    public TextBox textBox;

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
