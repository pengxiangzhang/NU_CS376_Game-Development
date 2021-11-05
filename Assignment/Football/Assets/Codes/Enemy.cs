using UnityEngine;

public class Enemy : MonoBehaviour
{
    private static Vector3 originalPos;
    public float speed;

    private void Update()
    {
        Vector3 pos = transform.position;
        float newY = Mathf.Sin(UnityEngine.Time.time * speed) * 2;
        transform.position = new Vector3(pos.x, newY, pos.z);
    }

    void OnCollisionStay2D(Collision2D collide)
    {
        if (collide.gameObject.name == "Ball")
        {
            ball.resetLocation();
            Score.CalculateScore(-1);
        }
        if (collide.gameObject.name == "Player")
        {
            Player.resetLocation();
            Score.CalculateScore(-1);
        }
    }
}
