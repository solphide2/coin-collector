using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenController : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Reloads the main gameplay scene
            SceneManager.LoadScene("SampleScene"); 
        }
    }
}
