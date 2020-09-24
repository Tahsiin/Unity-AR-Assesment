using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationMovement : MonoBehaviour
{
    public bl_Joystick JoystickRotate;
    private float Speed = 5;
    private int z =0;
    // Update is called once per frame
    void Update()
    {
        float h = JoystickRotate.Horizontal; //get the vertical value of joystick
        float v = JoystickRotate.Vertical;//get the horizontal value of joystick
        
        Vector3 translate = (new Vector3(-v, h, z) * Time.deltaTime) * Speed;
        transform.Rotate(translate);
        
    }
}
