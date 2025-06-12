using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody2D;
    public float flapAura;
    public eventScore logic;
    private bool gameOver = false;
    public AudioSource flapAudio;
    private float time = 0.6f;
    private float countTime = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<eventScore>();
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space) && !gameOver)
        {
            myRigidBody2D.linearVelocity = Vector2.up * flapAura;
            if (countTime >= time)
            {
                flapAudio.Play();
                countTime = 0;
            }
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (!logic.getIsGameOver())
        {
            logic.gameOver();
            logic.changeIsGameOver(true);
            gameOver = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Target"))
        {
            gameOver = true;
        }
    }

}
