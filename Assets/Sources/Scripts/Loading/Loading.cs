using UnityEngine;

public class Loading
{
    public void Load(string key, Star[] stars)
    {
        int value = PlayerPrefs.GetInt(key);

        for (int i = 0; i < value; i++)
            stars[i].Enable();
    }
}
