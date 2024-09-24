using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    private const string ÑompletedLevel = nameof(ÑompletedLevel);

    [SerializeField] private MovementRoot _movementRoot;
    [SerializeField] private Player _player;
    [SerializeField] private PlayerDeath _playerDeath;
    [SerializeField] private PlayerWallet _playerWallet;
    [SerializeField] private FinishTrigger _finishTrigger;
    [SerializeField] private Sounds _sounds;

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
        _playerWallet.WalletChanged += OnWalletChanged;
        _finishTrigger.Finished += OnFinished;
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
        _playerWallet.WalletChanged -= OnWalletChanged;
        _finishTrigger.Finished -= OnFinished;
    }

    private void OnDied()
    {
        _sounds.PlayHit();
        _playerDeath.Die();
    }

    private void OnWalletChanged()
    {
        _sounds.PlayTake();
    }

    private void OnFinished()
    {
        int indexActiveScene = SceneManager.GetActiveScene().buildIndex;
        _savingProgress.Save(indexActiveScene, ÑompletedLevel);
        SceneManager.LoadScene(0);
    }
}
