using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraFeedController : MonoBehaviour
{
    public int cameraNumber;
    public Button toggleButton;
    public Button buttonLeft;
    public Button buttonRight;
    public Sprite buttonOn;
    public Sprite buttonOff;
    public GameObject loggerObject;
    public GameObject recordingIndicator;
    Logger logger;
    bool isCameraOn;
    RawImage image;
    Color on;
    Color off;
    float startTime;
    int passedTime;


    bool isIndicatorOn = true;
    // Start is called before the first frame update
    void Start()
    {
        isCameraOn = true;
        on = new Color(255, 255, 255, 255);
        off = new Color(0, 0, 0, 255);
        image = GetComponent<RawImage>();
        logger = loggerObject.GetComponent<Logger>();
        startTime = Time.time;

        InvokeRepeating("ToggleIndicatorLight", 0, 1f); // repeat every 1s
    }

    // Update is called once per frame
    void Update()
    {
        if (isCameraOn)
        {
            image.color = on;
            toggleButton.GetComponent<Image>().sprite = buttonOff;
            buttonLeft.gameObject.SetActive(true);
            buttonRight.gameObject.SetActive(true);
            recordingIndicator.SetActive(true);         
        }
        else
        {
            image.color = off;
            toggleButton.GetComponent<Image>().sprite = buttonOn;
            buttonLeft.gameObject.SetActive(false);
            buttonRight.gameObject.SetActive(false);
            recordingIndicator.SetActive(false);
        }
    }

    public void Toggle()
    {
        if (isCameraOn)
        {
            isCameraOn = false;
            passedTime = (int)(Time.time - startTime);
            logger.Add("Kamera " + cameraNumber + " wurde <color=red>ausgeschaltet</color> " +
                "und hat für " + passedTime + " Sekunden aufgezeichnet");
        }
        else
        {
            isCameraOn = true;
            startTime = Time.time;
            logger.Add("Kamera " + cameraNumber + " <color=green>eingeschaltet</color>");         
        }
    }

    void ToggleIndicatorLight()
    {
        if(isIndicatorOn)
        {
            recordingIndicator.GetComponent<MeshRenderer>().material.color = Color.red;
            isIndicatorOn = false;
        }
        else
        {
            recordingIndicator.GetComponent<MeshRenderer>().material.color = off;
            isIndicatorOn = true;
        }
            
    }
}
