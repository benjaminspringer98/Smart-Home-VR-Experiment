using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HandAttachSelector : MonoBehaviour
{
    public XRDirectInteractor leftHand;
    public XRDirectInteractor rightHand;
    public Transform leftHandTransform;
    public Transform rightHandTransform;
    private XRGrabInteractable grab;

    // Start is called before the first frame update
    void Start()
    {
        grab = GetComponent<XRGrabInteractable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (leftHand.hasSelection)
            grab.attachTransform = leftHandTransform;
        if (rightHand.hasSelection)
            grab.attachTransform = rightHandTransform;
    }
}
