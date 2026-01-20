using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public PlayerHealth player;
    public Text healthText;

    void OnEnable()
    {
        player.OnHealthChanged += UpdateHealth;
    }

    void OnDisable()
    {
        player.OnHealthChanged -= UpdateHealth;
    }

    void UpdateHealth(int hp)
    {
        healthText.text = "HP: " + hp;
    }
}
