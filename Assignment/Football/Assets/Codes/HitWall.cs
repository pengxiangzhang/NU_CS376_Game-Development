using UnityEngine;

public class HitWall : MonoBehaviour
{
    void OnCollisionStay2D(Collision2D collide)
    {
        if (collide.gameObject.name == "Ball")
        {
            ball.resetLocation();
        }
    }
}
