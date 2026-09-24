using UnityEngine;

public class random_carrot_generation : MonoBehaviour
{
    public float minX= -8.88f;
    public float minY= -5.0f;
    public float maxX = 8.88f;
    public float maxY = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    void ChangePosition()
    {
        float randomx = Random.Range(minX, maxX);
        float randomy = Random.Range(minY, maxY);
        Debug.Log("Generated Math -> X: " + randomx + " | Y: " + randomy);
        transform.position = new Vector3(randomx, randomy, transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("change");
            ChangePosition();
        }
        
    }
}
