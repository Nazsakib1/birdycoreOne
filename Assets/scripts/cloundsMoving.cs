using UnityEngine;

public class cloundsMoving : MonoBehaviour
{
    public float movingSpeed = 6;
    public float deathZone;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + (Vector3.left * movingSpeed) * Time.deltaTime;

        if (transform.position.x < -50)
        {
            Debug.Log("cloud deleted");
            Destroy(gameObject);
        }



    }
}
