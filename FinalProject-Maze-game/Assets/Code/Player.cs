using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public float playerSpeed = 1.0f;
    public TMP_Text ending;
    public TMP_Text score;
    public TMP_Text timming;
    public static float startTime;
    private Rigidbody playerRB;
    private int PickUpCount = 10;
    private bool gameEnded = false;
    private float winTime;
    public AudioSource winSound;
    public AudioSource lostSound;
    public AudioSource scoreSound;
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        score.text = "Remining Pickup: " + PickUpCount;
    }

    void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
        playerRB.AddForce(movement * playerSpeed);
        if (!gameEnded)
            timming.text = "Time Used: " + (Time.realtimeSinceStartup - startTime).ToString("#0.00") + " Seconds";
    }


    void OnCollisionStay(Collision collide)
    {
        if (collide.gameObject.tag == "Floor")
        {
            if (!gameEnded)
                lostSound.Play();
            gameEnded = true;
            playerRB.velocity = Vector3.zero;
            playerRB.angularVelocity = Vector3.zero;
            ending.text = "OOPS...";
            timming.text = "";
        }
        else if (collide.gameObject.tag == "Pin")
        {
            scoreSound.Play();
            Destroy(collide.gameObject);
            PickUpCount -= 1;
            if (PickUpCount != 0)
                score.text = "Remining Pickup: " + PickUpCount;
            else
                score.text = "You have collected all pickups, Go to the Finish line.";
        }
        else if (collide.gameObject.name == "Finish Line")
        {
            if (PickUpCount != 0)
                score.text = "Remining Pickup: " + PickUpCount + "\nYou need to collect all pickup before come to the winning line";
            else
            {
                if (!gameEnded)
                {
                    winSound.Play();
                    winTime = Time.realtimeSinceStartup;
                    gameEnded = true;
                }
                playerRB.velocity = Vector3.zero;
                playerRB.angularVelocity = Vector3.zero;
                timming.text = "";
                ending.text = "You Win!\nThe time you use is " + (winTime - startTime).ToString("#0.00") + " seconds";
            }
        }
    }
}
