using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveRight : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressed;
    public GameObject cam;

    void Update()
    {
        if (isPressed)
        {
            right();
        }
    }
    public void OnPointerDown(PointerEventData data)
    {
        isPressed = true;
    }
    public void OnPointerUp(PointerEventData data)
    {
        isPressed = false;
    }

    public void right()
    {
        cam.transform.Rotate(0, 0.2f, 0);
    }
}