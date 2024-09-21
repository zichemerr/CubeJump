using UnityEngine;

public class LoadingController : MonoBehaviour
{
    private const string СompletedLevel = nameof(СompletedLevel);

    [SerializeField] private Star[] _firstStars;

    private Loading _loading;

    private void Start()
    {
        _loading = new Loading();
        _loading.Load(СompletedLevel, _firstStars);
    }

    [ContextMenu(nameof(ClearProgres))]
    private void ClearProgres()
    {
        PlayerPrefs.DeleteAll();
    }
}
