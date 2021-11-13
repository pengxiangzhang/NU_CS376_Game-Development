using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5.0f;
    public float BulletSpeed = 10;
    private static Rigidbody2D player;
    public Sprite flyLeftSprite;
    public Sprite flyRightSprite;
    public Sprite flyOrigSprite;
    public SpriteRenderer spriteRenderer;
    public GameObject bulletPrefeb;
    public GameObject enemyPrefeb;
    public static GameObject enemyPrefebStatic;
    private float nextEnemy = 1.0f;
    public float Enemyperiod = 1.0f;
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        enemyPrefebStatic = enemyPrefeb;
    }

    void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        Vector3 screenPos = Camera.main.WorldToScreenPoint(player.position);
        if (horizontal == 1)
            spriteRenderer.sprite = flyRightSprite;
        else if (horizontal == -1)
            spriteRenderer.sprite = flyLeftSprite;
        else
            spriteRenderer.sprite = flyOrigSprite;

        if (screenPos.x > Screen.width - 10)
            if (horizontal == 1)
                horizontal = 0;
        if (screenPos.x < 10)
            if (horizontal == -1)
                horizontal = 0;
        if (screenPos.y > Screen.height - 10)
            if (vertical == 1)
                vertical = 0;
        if (screenPos.y < 10)
            if (vertical == -1)
                vertical = 0;
        if (Time.time > nextEnemy)
        {
            nextEnemy += Enemyperiod;
            newEnemy();
        }

        player.velocity = new Vector2(horizontal * playerSpeed, vertical * playerSpeed);

        if (Input.GetKeyDown("space"))
        {
            var bullet = Instantiate(bulletPrefeb, player.transform.up + player.transform.position, Quaternion.identity);
            Rigidbody2D Bullet = bullet.GetComponent<Rigidbody2D>();
            Bullet.velocity = BulletSpeed * (Bullet.transform.position - player.transform.position);
        }
    }

    public static void newEnemy()
    {
        var location = new Vector3(Random.Range(-8, 8), 4.5f, 0);
        Instantiate(enemyPrefebStatic, location, Quaternion.identity);
    }
}
