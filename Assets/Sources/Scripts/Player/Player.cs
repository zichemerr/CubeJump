using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    public event Action Finished;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Obstacle>())
            Finished?.Invoke();
    }
}
