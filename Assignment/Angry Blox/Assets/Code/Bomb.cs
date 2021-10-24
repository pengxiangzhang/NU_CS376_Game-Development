using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float ThresholdForce = 2;
    public GameObject ExplosionPrefab;
    private void Destruct()
    {
        Destroy(gameObject);
    }

    private void Boom()
    {
        // TODO:
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // TODO:
    }
}
