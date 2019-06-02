using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public static event Action OnSceneEnd = delegate { };
    
    public void LoadScene(int buildIndex)
    {
        StartCoroutine(Load(buildIndex));
    }

    private static IEnumerator Load(int buildIndex)
    {
        Time.timeScale = 1f;
        
        OnSceneEnd();
        OnSceneEnd = delegate { };
        
        yield return new WaitForSeconds(1f);
        
        SceneManager.LoadScene(buildIndex);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
