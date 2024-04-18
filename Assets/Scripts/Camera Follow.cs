using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothness;
    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, 1 - smoothness);
    }
}
