using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    public bool isScreenOn;
    public bool isShowingCamera;
    public Material screenOff;
    public Material screenCamera;
    public GameObject activityDetectedDialogue;
    public GameObject screen;
    MeshRenderer screenRenderer;

    // Start is called before the first frame update
    //void Start()
    //{
    //    // screen and 
    //    screenRenderer = screen.GetComponent<MeshRenderer>();
    //    screenRenderer.material = screenOff;
    //    gameObject.SetActive(false);
    //}

    //// Update is called once per frame
    //void FixedUpdate()
    //{
    //    Debug.Log("Test");
    //}

    //void renderCamera()
    //{
    //    if (isShowingCamera)
    //        screenRenderer.material = screenCamera;
    //    else
    //        screenRenderer.material = screenOff;
    //}

    

    //void renderScreen()
    //{
    //    if (isScreenOn)
    //    {
    //        screenRenderer.material = screenCamera;
    //        gameObject.SetActive(true);

    //    }         
    //    else 
    //    {
    //        screenRenderer.material = screenOff;
    //        gameObject.SetActive(false);
    //    }  
    //}

    //public void toggleIsShowingCamera()
    //{
    //    if (isShowingCamera)
    //        isShowingCamera = false;
    //    else
    //        isShowingCamera = true;  
    //}

 
}
