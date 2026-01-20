using UnityEngine;

public class SignedAngleRotation : MonoBehaviour
{
    float angle;

    void Update()
    {
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mouse.z = 0;

        Vector2 dir = mouse - transform.position;
        angle = Vector2.SignedAngle(Vector2.right, dir);

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 30),
                  "Angle: " + angle.ToString("F2"));
    }
}
