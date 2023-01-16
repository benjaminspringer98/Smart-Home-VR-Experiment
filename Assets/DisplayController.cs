using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayController : MonoBehaviour
{
    public bool isShowingCamera;
    public Material screenOff;
    MeshRenderer screenRenderer;
    
    // Start is called before the first frame update
    void Start()
    {
        screenRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void ShowCamera()
    //{
    //    Debug.Log("Showing camera");
    //    screenRenderer.material = screenCamera;
    //    isShowingCamera = true;
    //}

    public void TurnScreenOn()
    {
        gameObject.SetActive(true);
    }

    public void TurnScreenOff()
    {
        gameObject.SetActive(false);
    }
}
