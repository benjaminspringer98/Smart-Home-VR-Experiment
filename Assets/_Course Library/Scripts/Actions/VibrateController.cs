using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

/// <summary>
/// Vibrate the XR Controller
/// </summary>
public class VibrateController : MonoBehaviour
{
    public XRDirectInteractor leftHand;
    public XRDirectInteractor rightHand;
    public float strongVibrate = 0.75f;
    public float weakVibrate = 0.25f;

    public ActionBasedController leftHandController;
    public ActionBasedController rightHandController;
    public XRGrabInteractable tablet;

    private void Awake()
    {
    }

    public void Vibrate(float amplitude, float duration)
    {
        if (leftHand.selectTarget == tablet)
            leftHandController.SendHapticImpulse(amplitude, duration);
        if (rightHand.selectTarget == tablet)
            rightHandController.SendHapticImpulse(amplitude, duration);
        // OpenVR currently only supports amplitude

    }

    public void VibrateWeak(float duration)
    {
        if (leftHand.selectTarget == tablet)
            leftHandController.SendHapticImpulse(weakVibrate, duration);
        if (rightHand.selectTarget == tablet)
            rightHandController.SendHapticImpulse(weakVibrate, duration);
    }

    public void VibrateStrong(float duration)
    {
        if (leftHand.selectTarget == tablet)
            leftHandController.SendHapticImpulse(strongVibrate, duration);
        if (rightHand.selectTarget == tablet)
            rightHandController.SendHapticImpulse(strongVibrate, duration);
    }
}
