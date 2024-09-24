using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelStart : MonoBehaviour
{
    private const string ÑompletedLevel = nameof(ÑompletedLevel);

    public void StartLevel(int indexScene)
    {
        int completedLevel = PlayerPrefs.GetInt(ÑompletedLevel);

        if (indexScene <= completedLevel + 1)
            SceneManager.LoadScene(indexScene);
    }
}
