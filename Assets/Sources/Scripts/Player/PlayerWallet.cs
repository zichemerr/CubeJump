using UnityEngine;

public class PlayerWallet : MonoBehaviour
{
    [SerializeField] private WalletView _walletView;

    private int _coins;

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
        _coins++;
        _walletView.ShowDisplay(_coins);
    }
}
