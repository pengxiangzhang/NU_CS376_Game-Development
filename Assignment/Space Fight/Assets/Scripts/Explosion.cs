using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject explosionPrefab;
    public static GameObject explosionPrefabStatic;
    // Start is called before the first frame update
    void Start()
    {
        explosionPrefabStatic = explosionPrefab;
    }

    // Update is called once per frame
    public static void explosion(Vector3 location)
    {
        var explosion = Instantiate(explosionPrefabStatic, location, Quaternion.identity);
        Destroy(explosion, 1);
    }
}
