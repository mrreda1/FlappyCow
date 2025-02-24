using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore;
    public Text ScoreText;
    public GameObject gameOverScreen;

    [ContextMenu("Increament Score")]
    public void addPoints(in int points) {
        playerScore += points;
        ScoreText.text = playerScore.ToString();
    }
    
    public void restartScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver() {
        gameOverScreen.SetActive(true);
    }
}
