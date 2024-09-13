using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    [SerializeField] private MovementRoot _movementRoot;
    [SerializeField] private Player _player;

    private void Start()
    {
        _movementRoot.Init();
    }

    private void OnEnable()
    {
        _player.Finished += OnFinish;
    }

    private void OnDisable()
    {
        _player.Finished -= OnFinish;
    }

    private void OnFinish()
    {
        SceneManager.LoadScene(0);
    }
}
