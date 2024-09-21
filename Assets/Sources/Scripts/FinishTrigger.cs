using System;
using UnityEngine;

public class FinishTrigger : MonoBehaviour
{
    public event Action Finished;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>())
            Finished?.Invoke();
    }
}
