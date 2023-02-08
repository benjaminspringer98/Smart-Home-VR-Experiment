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
        if (leftHand.selectTarget == grab)
            grab.attachTransform = leftHandTransform;
        if (rightHand.selectTarget == grab)
            grab.attachTransform = rightHandTransform;
    }
}
