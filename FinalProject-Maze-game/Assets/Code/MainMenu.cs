using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadScene(int i)
    {
        SceneManager.LoadScene(i);
        Player.startTime = Time.realtimeSinceStartup;
    }

}
