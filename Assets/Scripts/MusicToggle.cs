using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    [SerializeField] private Sprite muteIcon = null;
    [SerializeField] private Sprite unmuteIcon = null;
    
    private Image toggleImage = null;

    private void Start()
    {
        toggleImage = GetComponent<Image>();
    }

    public void ToggleMusic()
    {
        AudioSource music = GameObject.Find("AudioController").GetComponent<AudioSource>();

        bool e = !music.enabled;
        music.enabled = e;
        toggleImage.sprite = e ? muteIcon : unmuteIcon;
    }
}
