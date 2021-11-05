using UnityEngine;

public class ball : MonoBehaviour
{
    private static Rigidbody2D ballBoby;
    private static Vector3 originalPos;

    void Start()
    {
        ballBoby = GetComponent<Rigidbody2D>();
        originalPos = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }

    public static void resetLocation()
    {
        ballBoby.transform.position = originalPos;
    }
}
