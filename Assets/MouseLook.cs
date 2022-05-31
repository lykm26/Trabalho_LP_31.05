using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    float xRotation = 0f;
    public Vector2 turn;
    public float sensitivity = 50;
    public Vector3 deltaMove;
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;        
    }

    // Update is called once per frame
    void Update()  
    {
        turn.x += Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        turn.y = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;
        xRotation -= turn.y;
        xRotation = Mathf.Clamp(xRotation, -20f, 20f);
        transform.localRotation = Quaternion.Euler(xRotation, turn.x, 0);
    }
}
