using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    Vector3 offset = new Vector3(3f, 0f, -10f);
    float smoothTime = 0.20f;
    Vector3 velocity = Vector3.zero;

    [SerializeField] private Transform target;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame.
    // Fixed update means that this code will run at fixed time intervals rather than the frame rate of my computer
    void FixedUpdate()
    {

        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}