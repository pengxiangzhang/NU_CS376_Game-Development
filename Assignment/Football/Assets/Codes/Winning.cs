using UnityEngine;


public class Winning : MonoBehaviour
{
    private Rigidbody2D wall;

    void Start()
    {
        wall = GetComponent<Rigidbody2D>();
    }

    void OnCollisionStay2D(Collision2D collide)
    {
        if (collide.gameObject.name == "Player")
        {
            Score.CalculateScore(-1);
            Player.resetLocation();
            ball.resetLocation();
        }
        if (collide.gameObject.name == "Ball")
        {
            Score.CalculateScore(1);
            Player.resetLocation();
            ball.resetLocation();
        }
    }

}
