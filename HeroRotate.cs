using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HeroRotate : MonoBehaviour, IDragHandler, IEndDragHandler
{
   public GameObject rotator;
   public float rotSpeed = 5f;
   float rotX;
   bool dragEnds;
   public float yAngleValue;

    private void Update() 
    {   
       if(dragEnds == true)
       {
           SetDefRotation(); 
           
            if (rotator.transform.rotation == Quaternion.identity)
            {
                rotator.transform.rotation = Quaternion.Euler (0, 0, 0);
                dragEnds = false;
            }
       }  
    }

    public void OnDrag(PointerEventData eventData) 
    {
        dragEnds = false;
        rotX = Input.GetAxis("Mouse X") * rotSpeed;
        rotator.transform.Rotate(0, -rotX, 0, Space.Self);
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        dragEnds = true;
    }
    public void SetDefRotation() 
    {
        rotator.transform.rotation = Quaternion.Lerp(rotator.transform.rotation, Quaternion.identity, 2f * Time.deltaTime); 
    }

    public void SetRotationToZero()
    {
        rotator.transform.rotation = Quaternion.Euler (0, 0, 0);
    }
}
