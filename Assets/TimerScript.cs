using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public bool gameStarted = false;
    public float timeRemaining = 20f;
    public float carrotsCollected = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStarted == true)
        {
            while (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }

            if (timeRemaining <= 0)
            {
                gameStarted = false;
            }
        }
        
        
        
    }
}
