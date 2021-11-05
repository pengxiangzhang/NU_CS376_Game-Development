using TMPro;
using UnityEngine;
using System;

public class Ending : MonoBehaviour
{
    private static TMP_Text text;
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    public static void showEnding()
    {
        text.enabled = true;
        text.text = String.Format("Times Up!\nYour Score: {0}", Score.score);
        UnityEngine.Time.timeScale = 0;
    }
}
