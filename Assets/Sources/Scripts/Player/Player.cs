using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action Died;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Obstacle>())
            Died?.Invoke();
    }
}
