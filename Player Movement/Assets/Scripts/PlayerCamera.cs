using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    //Sets the mouses sensitivity
    public float XSensitivity;
    public float YSensitivity;

    public Transform PlayerOrientation;

    //Will be used to see the rotation of the mouse
    public float XRotation;
    public float YRotation;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    
    void Update()
    {
        //Gets the axis data for X and Y
        float XMouse = Input.GetAxisRaw("Mouse X") * Time.deltaTime * XSensitivity;
        float YMouse = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * YSensitivity;

        YRotation += XMouse;
        XRotation += YMouse;
        XRotation = Mathf.Clamp(XRotation, -90f, 90f);

        //Rotate camera and the orientation
        transform.rotation = Quaternion.Euler(XRotation, YRotation, 0);
        PlayerOrientation.rotation = Quaternion.Euler(0, YRotation, 0);
    }
}
