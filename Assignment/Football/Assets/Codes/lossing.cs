using UnityEngine;

public class lossing : MonoBehaviour
{

    void OnCollisionStay2D(Collision2D collide)
    {
        if (collide.gameObject.name == "Ball")
        {
            Score.CalculateScore(-1);
            Player.resetLocation();
            ball.resetLocation();
        }
    }
}
