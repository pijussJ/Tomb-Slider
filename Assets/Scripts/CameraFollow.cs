using UnityEngine;

[ExecuteAlways]
public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    [Range(0f,0.999f)]public float smoothness;

    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,target.position + offset,1 - smoothness);
    }
}