using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField]
    private float cameraSpeed = 6.0f;
    private Vector3 direction = Vector3.zero;
    // Update is called once per frame
    void Update()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
        this.transform.position = this.transform.position + direction * Time.deltaTime * cameraSpeed;
    }
}
