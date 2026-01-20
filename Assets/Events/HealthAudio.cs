using UnityEngine;

public class HealthAudio : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public AudioSource audioSource;

    void OnEnable()
    {
        playerHealth.OnHealthChanged += PlayHitSound;
    }

    void OnDisable()
    {
        playerHealth.OnHealthChanged -= PlayHitSound;
    }

    void PlayHitSound(int hp)
    {
        audioSource.Play();
    }
}
