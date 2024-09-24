using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _hit;
    [SerializeField] private AudioClip _take;

    public void PlayHit() => _audioSource.PlayOneShot(_hit);

    public void PlayTake() => _audioSource.PlayOneShot(_take);
}
