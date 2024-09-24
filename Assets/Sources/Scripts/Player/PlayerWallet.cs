using System;
using UnityEngine;

public class PlayerWallet : MonoBehaviour
{
    [SerializeField] private WalletView _walletView;

    public int Coins { get; private set; }
    public event Action WalletChanged;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Coin>())
        {
            Destroy(other.gameObject);
            AddCoin();
        }
    }

    private void AddCoin()
    {
        Coins++;
        WalletChanged?.Invoke();
        _walletView.ShowDisplay(Coins);
    }
}
