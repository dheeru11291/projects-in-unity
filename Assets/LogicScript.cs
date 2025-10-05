using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore=0;
    public Text scoreText;
    public GameObject gameOverScreen;
    //public AudioSource gameSound;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore=playerScore+scoreToAdd;
        scoreText.text=playerScore.ToString();
        //gameSound.Play();
    }
    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}