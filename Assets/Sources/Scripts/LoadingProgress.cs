using UnityEngine;

public class LoadingProgress : MonoBehaviour
{
    private const string СompletedLevel = nameof(СompletedLevel);

    [SerializeField] private Star[] _stars;

    private void Start()
    {
        int completedLevel = PlayerPrefs.GetInt(СompletedLevel);

        for (int i = 0; i < completedLevel; i++)
            _stars[i].Enable();
    }
}
