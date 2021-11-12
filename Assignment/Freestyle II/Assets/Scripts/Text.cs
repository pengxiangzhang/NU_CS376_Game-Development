using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class Text : MonoBehaviour
{
    public static float timer = 30;
    public TMP_Text ending;
    public static float score;
    private static TMP_Text text;
    void Start()
    {
        text = GetComponent<TMP_Text>();

    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            TextUpdate(timer, score);
        }
        else
        {
            timer = 0;
            TextUpdate(timer, score);
            Ending(ending, score);
        }
    }

    public static void AddScore(float addscore)
    {
        score += addscore;
        TextUpdate(timer, score);
    }

    private static void TextUpdate(float time, float score)
    {
        text.text = String.Format("Time: {0}\nScore: {1}", time.ToString("#0.00"), score);
    }

    private static void Ending(TMP_Text ending, float score)
    {
        ending.text = String.Format("Game Over!\nYour Score: {0}", score);
        UnityEngine.Time.timeScale = 0;
    }
}
