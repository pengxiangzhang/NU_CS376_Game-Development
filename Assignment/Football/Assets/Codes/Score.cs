using System;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static float score;
    private static TMP_Text text;
    public AudioSource winAudio;
    public AudioSource lossAudio;
    private static AudioSource winAudioStatic;
    private static AudioSource lossAudioStatis;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
        winAudioStatic = winAudio;
        lossAudioStatis = lossAudio;
        UpdateScore();
    }

    public static void CalculateScore(float points)
    {
        if (points > 0)
        {
            winAudioStatic.Play();
        }
        else if (points < 0)
        {
            lossAudioStatis.Play();
        }
        score += points;
        UpdateScore();

    }

    private static void UpdateScore()
    {
        text.text = String.Format("Score: {0}", score);
    }
}
