using System;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class pipeMovingScript : MonoBehaviour
{
    private float movingSpeed = 6; 
    public float deathZone;
    private eventScore scoreManager;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = FindAnyObjectByType<eventScore>();
    }

    // Update is called once per frame
    void Update()
    {

        if (scoreManager != null) {
            movingSpeed = Mathf.Clamp(scoreManager.getScore() * 0.1f + 6f, 6f, 20f);
        }

        transform.position = transform.position + (Vector3.left * movingSpeed) * Time.deltaTime;

        if (transform.position.x < -50)
        {
            Debug.Log("Pipe deleted");
            Destroy(gameObject);
        }
    }

    public float getMovingSpeed() { 
        return movingSpeed; 
    }
}
