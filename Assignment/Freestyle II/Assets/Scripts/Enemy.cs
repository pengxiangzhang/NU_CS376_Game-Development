using UnityEngine;

public class Enemy : MonoBehaviour
{
    private static Rigidbody2D enemy;
    public SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "bullet(Clone)")
        {

            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
            Explosion.explosion(gameObject.transform.position);
            Text.AddScore(1);
        }
        else if (collision.collider.name == "player")
        {
            Explosion.explosion(gameObject.transform.position);
            Destroy(collision.collider.gameObject);
            Destroy(gameObject);
            Text.timer = 0;
        }
        else if (collision.collider.name == "wall")
        {
            Destroy(gameObject);
            Explosion.explosion(gameObject.transform.position);
            Text.timer = 0;
        }
    }
}
