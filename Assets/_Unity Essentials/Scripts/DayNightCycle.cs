using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day-Night Cycle Settings")]
    [Tooltip("Duration of a full day in seconds.")]
    public float dayDurationInSeconds = 120f; // Default: 2 minutes for a full rotation

    private float rotationSpeed;

    void Start()
    {
        // Calculate the rotation speed based on the duration of a full day
        // A full day corresponds to 360 degrees of rotation
        rotationSpeed = 360f / dayDurationInSeconds;
    }

    void Update()
    {
        // Rotate the light around the X-axis to simulate the day-night cycle
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
}
