using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public GameObject player;
    public float distanceFromPlayer = 15f;
    public float heightFromPlayer = 13.5f;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + heightFromPlayer, player.transform.position.z - distanceFromPlayer);
    }
}