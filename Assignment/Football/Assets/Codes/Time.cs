using UnityEngine;
using TMPro;
using System;

public class Time : MonoBehaviour
{
    public float timer;
    private static TMP_Text text;
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= UnityEngine.Time.deltaTime;
            UpdateScore(timer);
        }
        else
        {
            timer = 0;
            UpdateScore(timer);
            Ending.showEnding();
        }
    }

    private static void UpdateScore(float time)
    {
        text.text = String.Format("Time: {0}", time.ToString("#0.00"));
    }
}
