using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelStart : MonoBehaviour
{
    private const string ÑompletedLevel = nameof(ÑompletedLevel);

    public void StartLevel(int index)
    {
        if (index == PlayerPrefs.GetInt(ÑompletedLevel) + 1)
            SceneManager.LoadScene(index);
    }
}
