using UnityEngine;
using UnityEngine.SceneManagement;
public class Manager : MonoBehaviour
{
    bool gameEnded = false;
    public Movement movement;
    public CalculateScore score;
    public float restartDelay = 1f;
    public void EndGame()
    {
        if (!gameEnded)
        {
            gameEnded = true;
            FindObjectOfType<Movement>().enabled = false;
            FindObjectOfType<CalculateScore>().showGameOver();
            Invoke("Restart",restartDelay);
        }
    }
    public void Win()
    {
        gameEnded = true;
        FindObjectOfType<CalculateScore>().showGameWon();
        Invoke("Restart", restartDelay);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
