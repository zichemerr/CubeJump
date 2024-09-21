using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    private const string ÑompletedLevel = nameof(ÑompletedLevel);

    [SerializeField] private MovementRoot _movementRoot;
    [SerializeField] private Player _player;
    [SerializeField] private PlayerDeath _playerDeath;
    [SerializeField] private FinishTrigger _finishTrigger;

    private SavingProgress _savingProgress;

    private void Start()
    {
        _playerDeath.Init();
        _movementRoot.Init();
        _savingProgress = new SavingProgress();
    }

    private void OnEnable()
    {
        _player.Died += OnDied;
        _finishTrigger.Finished += OnFinished;
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
        _finishTrigger.Finished -= OnFinished;
    }

    private void OnDied()
    {
        _playerDeath.Die();
    }

    private void OnFinished()
    {
        int indexActiveScene = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(indexActiveScene);
        _savingProgress.Save(indexActiveScene, ÑompletedLevel);
        SceneManager.LoadScene(0);
    }
}
