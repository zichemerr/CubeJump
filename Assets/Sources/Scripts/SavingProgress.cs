using UnityEngine;

public class SavingProgress
{
    private const string СompletedLevel = nameof(СompletedLevel);

    public void Save(int indexScene)
    {
        PlayerPrefs.SetInt(СompletedLevel, indexScene);
    }
}
