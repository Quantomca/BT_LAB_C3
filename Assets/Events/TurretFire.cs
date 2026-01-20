using UnityEngine;

public class TurretFire : MonoBehaviour
{
    public PlayerHealth player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            player.TakeDamage(10);
            Debug.Log("Turret bắn Player");
        }
    }
}
