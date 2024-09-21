using UnityEngine;

public class PlayerWallet : MonoBehaviour
{
    [SerializeField] private WalletView _walletView;

    public int Coins { get; private set; }

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
        _walletView.ShowDisplay(Coins);
    }
}
