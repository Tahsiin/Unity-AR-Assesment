using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpawnObj : MonoBehaviour , IDragHandler, IEndDragHandler
{

    public GameObject NewGameObj;
    public GameObject parentObj; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnClick()
    {

        Instantiate(NewGameObj, transform.position, transform.rotation,parentObj.transform.parent);
        //NewGameObj.transform.parent = newParent.transform;

    }

     public void OnDrag(PointerEventData eventData)
    {
        
       // NewGameObj.position = Input.mousePosition;

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //Instantiate(NewGameObj, transform.position, transform.rotation);
       // transform.local
      //  transform.position = Input.mousePosition;

    }
}


