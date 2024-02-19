using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The target the camera should follow
    public float smoothing = 5f; // How smoothly the camera catches up with its target movement

    Vector3 offset; // The initial offset from the target

    void Start()
    {
        // Calculate the initial offset from the target's current position
        offset = transform.position - target.position;

        // Optional: Center the camera over the target at the start
        CenterCameraOnTarget();
    }

    void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }

    // Centers the camera over the target by adjusting its position based on the offset
    void CenterCameraOnTarget()
    {
        transform.position = target.position + offset;
    }
}
