using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    public float Amplitude;
    public float Frequency;
    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        Vector3 vec = startPosition;
        vec.x += Amplitude * Mathf.Sin(Time.time);
        transform.position = vec;
    }
}
