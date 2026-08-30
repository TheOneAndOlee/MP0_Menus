using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public int coolerScore = 0;

    public TextMeshProUGUI coolerTextbox;
    public TextMeshProUGUI textbox;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coolerTextbox.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void IncreaseScore() 
    {
        score++;
        textbox.text = "Your pointz: " + score;
    }

    public void IncreaseCoolerScore()
    {
        if (score >= 30)
        {
            coolerScore++;
            score -= 30;

            if (!coolerTextbox.enabled)
            {
                coolerTextbox.enabled = true;
                
            }
            textbox.text = "Your pointz: " + score;
            coolerTextbox.text = "Your kooler pointz: " + coolerScore;
        }
    }
}
