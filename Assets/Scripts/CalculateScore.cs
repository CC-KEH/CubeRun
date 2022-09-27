using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CalculateScore : MonoBehaviour
{
    public Transform player;
    public Movement movement;
    public Text scoreText;
    void Update()
    {
       scoreText.text = player.position.z.ToString("0");
    }
    public void showGameOver()
    {
        scoreText.text = "Game Over!";
    }
    public void showGameWon()
    {
        scoreText.text = "Level Complete!";
    }
}
