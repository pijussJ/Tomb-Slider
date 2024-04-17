using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothness;

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, smoothness);
    }
}