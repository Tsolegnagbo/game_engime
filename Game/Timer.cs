using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLeft = 60f;
    public Text timerText;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = "Time Left: " + Mathf.Round(timeLeft);

        if (timeLeft <= 0)
        {
            // Time's up - Game Over
            Debug.Log("Time's up!");
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
}
