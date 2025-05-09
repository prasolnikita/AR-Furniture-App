using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoldRotateButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public int direction = 1;
    public ObjectRotation rotator;

    private bool isHeld = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        isHeld = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        isHeld = false;
    }

    void Update()
    {
        if (isHeld && rotator != null)
        {
            rotator.RotateActiveObject(direction);
        }
    }
}
