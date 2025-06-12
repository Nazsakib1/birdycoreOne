using System;
using System.Threading;
using UnityEngine;

public class pipeSpawning : MonoBehaviour
{
    public GameObject pipe;
    private float spawnrate = 2;
    private double timer = 0;
    public float heightOffset = 10;
    private pipeMovingScript theScoreScript;
    private eventScore eventScore;
    public AudioSource spriteChangeAudio;
    private spriteChanger changerSprite;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
        theScoreScript = FindAnyObjectByType<pipeMovingScript>();
        eventScore = FindAnyObjectByType<eventScore>();
        changerSprite = FindAnyObjectByType<spriteChanger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (theScoreScript != null) 
        {
            spawnrate = Mathf.Clamp(12/theScoreScript.getMovingSpeed(), 0.005f, 2 );
        }
        if( timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }

        if (eventScore.getScore() > 100 && !changerSprite.getGen2Change())
        {
            spriteChangeAudio.Play();
            changerSprite.ChangeGen2(true);
        }
        else if (eventScore.getScore() < 100 && eventScore.getScore() > 49 && !changerSprite.getGen3Change())
        {
            spriteChangeAudio.Play();
            changerSprite.ChangeGen3(true);
        }
    }

    void spawnPipe()
    {
        float highOffset = transform.position.y + heightOffset; 
        float lowOffset = transform.position.y - heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x , UnityEngine.Random.Range(lowOffset, highOffset), 2), Quaternion.identity);
    }
}
