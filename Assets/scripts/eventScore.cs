using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class eventScore : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public GameObject gameOverscreen;
    public AudioSource gameThemeAudio;
    public AudioClip gameOverlayAudio;
    private bool isGameOver = false;

    [ContextMenu ("Increase Score")]
    void Start()
    {
 
    }
    public int getScore()
    {
        return score;
    }
    public void addPoints(int addScore)
    {
        score += addScore;
        scoreText.text = score.ToString();
    }

    public void restartGame()
    {
        Debug.Log("Play agian is clicked");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    } 

    public void gameOver()
    {
        gameThemeAudio.Stop();
        gameThemeAudio.PlayOneShot(gameOverlayAudio);
        gameOverscreen.SetActive(true);
    }


    public void changeIsGameOver(bool condition)
    {
        isGameOver = condition;
    }

    public bool getIsGameOver()
    {
        return isGameOver;
    }
}
