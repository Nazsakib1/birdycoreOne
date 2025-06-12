using UnityEngine;

public class isArea : MonoBehaviour
{
    private bool isColliding = false;
    public eventScore logic;

    private void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<eventScore>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Target"))
        {
            isColliding = true;
            Debug.Log("Objects are colliding");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Target") && !logic.getIsGameOver())
        {
            isColliding = false;
            Debug.Log("Objects are no longer colliding");
            logic.gameOver();
            logic.changeIsGameOver(false);
        }
    }

}
