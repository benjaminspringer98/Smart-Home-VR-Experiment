using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InCameraDetector : MonoBehaviour
{
    public Camera camera;
    public Material outputMaterial;
    Plane[] cameraFrustum;
    Bounds bounds;
    Collider collider;
    MeshRenderer renderer;
    public GameObject smartphone;
    public GameObject display;
    SmartphoneController smartphoneController;
    DisplayController displayController;

    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
        renderer = GetComponent<MeshRenderer>();
        smartphoneController = smartphone.GetComponent<SmartphoneController>();
        displayController = display.GetComponent<DisplayController>();
    }

    // Update is called once per frame
    void Update()
    {

        var bounds = collider.bounds;
        cameraFrustum = GeometryUtility.CalculateFrustumPlanes(camera);

        //if player is seen by security camera
        if (GeometryUtility.TestPlanesAABB(cameraFrustum, bounds))
        {       
            //if screen is off turn display on
            if (!smartphoneController.isScreenOn)
                smartphoneController.toggleScreen();

            // if smartphone does not have camera open
            // show dialogue to open camera     
            if (!displayController.isShowingCamera) {               
                smartphoneController.HideDefaultMenu();
                smartphoneController.ShowActivityDetectedDialogue();
            }
        }
        else
        {
            //Debug.Log("nicht sichtbar");
        }
    }
}
