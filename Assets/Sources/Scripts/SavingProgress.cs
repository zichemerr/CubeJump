using UnityEngine;
using UnityEngine.SceneManagement;

public class SavingProgress
{
    public void Save(int indexScene, string key)
    {
        int indexActiveScene = SceneManager.GetActiveScene().buildIndex;
        int savedScene = PlayerPrefs.GetInt(key);

        if (indexActiveScene > savedScene)
            PlayerPrefs.SetInt(key, indexScene);
    }
}
