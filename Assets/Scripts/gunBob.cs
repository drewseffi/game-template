using UnityEngine;

public class gunBob : MonoBehaviour
{
    [Header("Bobbing Settings")]
    public float bobFrequency = 5f;  // Speed of the bobbing
    public float bobAmplitude = 0.05f;  // Magnitude of the bobbing
    public float bobSmoothing = 5f;  // Smooth transition between bob states

    private Vector3 initialPosition;  // Store the initial local position of the weapon
    private float timer = 0f;  // Timer for the sine wave calculation

    void Start()
    {
        initialPosition = transform.localPosition;
    }

    void Update()
    {
        // Get player input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Check if the player is moving
        if (Mathf.Abs(horizontalInput) > 0.1f || Mathf.Abs(verticalInput) > 0.1f)
        {
            // Increase the timer based on the bobFrequency
            timer += Time.deltaTime * bobFrequency;

            // Calculate new positions using a sine wave
            float bobX = Mathf.Sin(timer) * bobAmplitude;
            float bobY = Mathf.Cos(timer * 2f) * bobAmplitude;

            // Apply bobbing to the local position
            Vector3 bobOffset = new Vector3(bobX, bobY, 0);
            transform.localPosition = Vector3.Lerp(transform.localPosition, initialPosition + bobOffset, Time.deltaTime * bobSmoothing);
        }
        else
        {
            // Reset the timer and smoothly return to the initial position when not moving
            timer = 0f;
            transform.localPosition = Vector3.Lerp(transform.localPosition, initialPosition, Time.deltaTime * bobSmoothing);
        }
    }
}
