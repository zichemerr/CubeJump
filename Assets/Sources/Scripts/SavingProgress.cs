using UnityEngine;

public class SavingProgress
{
    public void Save(int indexScene, string key)
    {
        PlayerPrefs.SetInt(key, indexScene);
    }
}
