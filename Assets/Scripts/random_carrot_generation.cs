using UnityEngine;
using TMPro;

public class random_carrot_generation : MonoBehaviour
{
    public float minX= -8.88f;
    public float minY= -5.0f;
    public float maxX = 8.88f;
    public float maxY = 5.0f;
    public int counter = 0;

    public TextMeshProUGUI scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       UpdateCounter();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object touching the carrot is tagged "Player"
        if (other.CompareTag("Player"))
        {
            ChangePosition();
            counter++;
            UpdateCounter();
            
        }
    }

    void CarrotCollector() {
        counter++;
        UpdateCounter();
        if (counter==5) {
            gameObject.SetActive(false);
        }
        else {
            ChangePosition();
        }
        
    }

    void ChangePosition()
    {
        float randomx = Random.Range(minX, maxX);
        float randomy = Random.Range(minY, maxY);
        Debug.Log("Generated Math -> X: " + randomx + " | Y: " + randomy);
        Debug.Log(counter);
        transform.position = new Vector3(randomx, randomy, transform.position.z);
        
    }

    void UpdateCounter()
    {
        if (scoreText!=null){
            scoreText.text = "x" + counter;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("change");
            CarrotCollector();
        }
        
        }
         
        
    }

