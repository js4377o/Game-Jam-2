using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CountdownTimer : MonoBehaviour
{
    public float startTime = 15f;       // set to 10 or 15 in Inspector
    public TMP_Text timerText;          // drag your Text (TMP) here

    private float timeLeft;

    void Start()
    {
        timeLeft = startTime;
        UpdateTimerText();
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0f)
            timeLeft = 0f;

        UpdateTimerText();

        // If time runs out -> restart the level
        if (timeLeft <= 0f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void UpdateTimerText()
    {
        // Shows like 14.9, 14.8... (nice for pressure)
        timerText.text = timeLeft.ToString("00.0");
    }
}
