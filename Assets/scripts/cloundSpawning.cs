using UnityEngine;

public class cloundSpawning : MonoBehaviour
{

    public GameObject clouds;
    private int heightOffest = 15;
    private float spawnRate = 2f;
    private float spawnTime = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnTime < spawnRate)
        {
            spawnTime += Time.deltaTime;
        }
        else
        {
            spawnTime = 0;
            spawnCloud();
        }
    }

    public void spawnCloud()
    {
        float highOffest = transform.position.y + heightOffest +1;
        float lowOffest = transform.position.y - heightOffest;
        Instantiate(clouds, new Vector3(25, UnityEngine.Random.Range(lowOffest, heightOffest), 1), Quaternion.identity);
    }
}
