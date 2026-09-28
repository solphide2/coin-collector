using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public TextMeshProUGUI resultText;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (resultText != null)
        {
            if (GameData.PlayerWon)
            {
                resultText.text = "YOU WIN!\nTime: " + GameData.FinalTime.ToString("F2") + "s";
            }
            else
            {
                resultText.text = "YOU LOSE!";
            }
        }
        
    }
    public void ReplayGame() {
        SceneManager.LoadScene("SampleScene");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
