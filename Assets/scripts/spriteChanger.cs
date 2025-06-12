using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

public class spriteChanger : MonoBehaviour
{
    public eventScore scoreManager;
    public SpriteRenderer renderPipe;
    public Sprite gen1;
    public Sprite gen2;
    public Sprite gen3;
    private bool gen2Change = false;
    private bool gen3Change = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreManager = FindAnyObjectByType<eventScore>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 20) {
            if (scoreManager.score < 100 && scoreManager.score >= 50)
            {
                renderPipe.sprite = gen2;
            }
            else if (scoreManager.score > 100)
            {
                renderPipe.sprite = gen3;
            }
            else
            {
                renderPipe.sprite = gen1;
            }
        }
    }

    public bool getGen2Change()
    {
        return gen2Change;
    }
    public bool getGen3Change()
    {
        return gen3Change;
    }
    public void ChangeGen2(bool input)
    {
        gen2Change = input;
    }
    public void ChangeGen3(bool input)
    {
        gen3Change = input;
    }
}
