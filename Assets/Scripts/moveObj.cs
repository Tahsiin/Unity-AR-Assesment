using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObj : MonoBehaviour
{
    private Vector3 mOffset;

    public GameObject NewGameObj;
    public GameObject parentObj; 
    private float mZCoord;
    public float distanceFromCamera = 3.0f;



    void OnMouseDown()

    {
       this.moveToPointedCursor();
    }


    private void moveToPointedCursor(){
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z; // Store offset = gameobject world pos - mouse world pos
        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();
        return;
    }
    private Vector3 GetMouseAsWorldPoint(){
        // Pixel coordinates of mouse (x,y)
        Vector3 mousePoint = Input.mousePosition;
        // z coordinate of game object on screen
        mousePoint.z = mZCoord;
        // Convert it to world points
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    void OnMouseDrag(){
        transform.position = GetMouseAsWorldPoint() + mOffset;
    }

    public void Instantiate(){

        // Get camera position
        // Get camera rotation
        // put in front of camera
        Instantiate(NewGameObj, Camera.main.transform.position + Camera.main.transform.forward * distanceFromCamera, transform.rotation,parentObj.transform.parent);

    }

}
