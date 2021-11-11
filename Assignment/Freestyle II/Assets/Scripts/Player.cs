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
    public GameObject bulletObj;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        if (horizontal > 0) spriteRenderer.sprite = flyRightSprite;
        else if (horizontal < 0) spriteRenderer.sprite = flyLeftSprite;
        else spriteRenderer.sprite = flyOrigSprite;
        player.velocity = new Vector2(horizontal * playerSpeed, vertical * playerSpeed);
        
        if (Input.GetKeyDown("space"))
        {
            var bullet = Instantiate(bulletObj, player.transform.up + player.transform.position, Quaternion.identity);
            Rigidbody2D Bullet = bullet.GetComponent<Rigidbody2D>();
            Bullet.velocity = BulletSpeed * (Bullet .transform.position - player.transform.position);

        }
    }
}
