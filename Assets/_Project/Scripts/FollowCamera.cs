using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Camera cam;
    public Transform target;
    public Vector3 offset;
    public float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        cam.transform.position = Vector3.Lerp(cam.transform.position, target.position + offset, Time.deltaTime * speed);
    }
}
