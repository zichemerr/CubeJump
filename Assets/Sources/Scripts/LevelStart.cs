using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelStart : MonoBehaviour
{
    private const string �ompletedLevel = nameof(�ompletedLevel);

    public void StartLevel(int indexScene)
    {
        int completedLevel = PlayerPrefs.GetInt(�ompletedLevel);

        if (indexScene <= completedLevel + 1)
            SceneManager.LoadScene(indexScene);
    }
}
