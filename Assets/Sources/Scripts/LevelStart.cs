using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelStart : MonoBehaviour
{
    private const string �ompletedLevel = nameof(�ompletedLevel);

    public void StartLevel(int index)
    {
        if (index == PlayerPrefs.GetInt(�ompletedLevel) + 1)
            SceneManager.LoadScene(index);
    }
}
