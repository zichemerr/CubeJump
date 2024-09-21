using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] private GameObject _deathMenu;

    public void Init()
    {
        Time.timeScale = 1f;
    }

    public void Die()
    {
        Time.timeScale = 0f;
        _deathMenu.SetActive(true);
    }
}