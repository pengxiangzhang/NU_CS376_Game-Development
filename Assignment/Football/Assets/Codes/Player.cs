using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5.0f;
    private static Rigidbody2D player;
    private static Vector3 originalPos;
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        player.velocity = new Vector2(horizontal * playerSpeed, vertical * playerSpeed);
    }

    public static void resetLocation()
    {
        player.transform.position = originalPos;
    }
}
