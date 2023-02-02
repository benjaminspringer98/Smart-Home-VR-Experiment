using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveLeft : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool isPressed;
    public GameObject cam;

    void Update()
    {
        if (isPressed)
        {
            left();
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

    public void left()
    {
        cam.transform.Rotate(0, -0.6f, 0);
    }
}