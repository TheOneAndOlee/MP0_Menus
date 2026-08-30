using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = FindAnyObjectByType<AudioSource>();
        if (audioSource != null)
        {
            Debug.Log("Found audio source");
        }
        else
        {
            Debug.Log("No audio source found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound()
    {
        audioSource.Play();
    }
}
