using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;

public class XRControllerButtonHold : MonoBehaviour
{
    public InputActionReference holdPrimaryButtonLeft;
    public InputActionReference holdPrimaryButtonRight;
    public InputActionReference holdSecondaryButtonLeft;
    public InputActionReference holdSecondaryButtonRight;
    public GameObject[] objToReset;
    private Vector3[] objPositions;
    private Quaternion[] objRotations;

     void Start()
        //store the original positions of gameobjects
    {
        objPositions = new Vector3[objToReset.Length];
        objRotations = new Quaternion[objToReset.Length];

        for (int i = 0; i < objToReset.Length; i++)
        {
            objPositions[i] = objToReset[i].transform.position;
            objRotations[i] = objToReset[i].transform.rotation;
        }
    }
    // Update is called once per frame
    void Update()
    {
        holdPrimaryButtonLeft.action.performed += ResetObjects;
        holdPrimaryButtonRight.action.performed += ResetObjects;
        holdSecondaryButtonLeft.action.performed += ResetObjects;
        holdSecondaryButtonRight.action.performed += ResetObjects;
    }

    private void ResetObjects(InputAction.CallbackContext context)
    {
        for(int i = 0; i < objToReset.Length; i++)
        {
            objToReset[i].transform.position = objPositions[i];
            objToReset[i].transform.rotation = objRotations[i];
        }
    }
}
