using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InCameraDetector : MonoBehaviour
{
    public Camera camera;
    Plane[] cameraFrustum;
    Bounds bounds;
    Collider collider;
    MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
        renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        var bounds = collider.bounds;
        cameraFrustum = GeometryUtility.CalculateFrustumPlanes(camera);
        if (GeometryUtility.TestPlanesAABB(cameraFrustum, bounds))
        {
            //renderer.sharedMaterial.color = Color.red;
            Debug.Log("sichtbar");
        } else
        {
            //renderer.sharedMaterial.color = Color.green;
            Debug.Log("nicht sichtbar");
        }
    }
}
