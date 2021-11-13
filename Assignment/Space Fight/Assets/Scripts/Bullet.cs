using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Start is called before the first frame update
    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
