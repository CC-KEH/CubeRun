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
        if (player.position.y < 1)
        {
            scoreText.text = "Game Over!";
            movement.enabled = false;
        }
        else
        {
            scoreText.text = player.position.z.ToString("0");
        }

    }
}
