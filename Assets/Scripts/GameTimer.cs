using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 20f;
    public TextMeshProUGUI timerText; 
    
    public bool isGameOver = false;

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {
            return;
        }

        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            if (timeRemaining <= 0)
            {
                timeRemaining = 0;
                GameOver(false);
            }
            else
            {
                UpdateTimerText("Time Remaining: ");
            }
        }
    }

    public void StopTimerAndWin()
    {
        if (!isGameOver)
        {
            GameOver(true);
        }
    }

    private void GameOver(bool playerWon)
    {
        isGameOver = true;

        if (playerWon)
        {
            if (timerText != null)
            {
                float finalTime = 20f - timeRemaining;
                GameData.PlayerWon = true;
                GameData.FinalTime = finalTime;
            }
        }
        else
        {
            GameData.PlayerWon = false;
            GameData.FinalTime = 0f;
            
            random_carrot_generation carrot = Object.FindFirstObjectByType<random_carrot_generation>();
            if (carrot != null)
            {
                carrot.gameObject.SetActive(false);
            }
        }
        SceneManager.LoadScene("EndMenu");
    } 

    private void UpdateTimerText(string prefix)
    {
        if (timerText != null)
        {
            timerText.text = prefix + timeRemaining.ToString("F2") + "s";
        }
    }

    public bool IsGameOver()
    {
        return isGameOver;
    }
}
