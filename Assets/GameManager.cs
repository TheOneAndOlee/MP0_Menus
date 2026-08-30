using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject creditsPrefab;
    public AudioSource audioSource;

    public Canvas optionsMenu;
    public Slider volumeSlider;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        optionsMenu.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void OpenCredits()
    {
        Instantiate(creditsPrefab, transform.position, Quaternion.identity);
    }
    
    public void ChangeVolume()
    {
        audioSource.volume = volumeSlider.value;
        Debug.Log(volumeSlider.value);
    }
    
    public void HideOptionsMenu()
    {
        optionsMenu.enabled = false;
    }

    public void ShowOptionsMenu()
    {
        optionsMenu.enabled = true;
    }

    public void PlayButtonSound()
    {
        audioSource.Play();
    }
}
