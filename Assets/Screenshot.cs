using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class Screenshot : MonoBehaviour
{
    public Camera cam;
    public GameObject originalRawImage;
    public RenderTexture originalRenderTexture;
    public GameObject scrollView;
    public GameObject content;
    public GameObject maximumPictureNumberReached;
    public ActionBasedController controller;
    public int count;

    public void Start()
    {
        originalRawImage.SetActive(false);
        HideMaximumPictureNumberReached();
    }
    public void Update()
    {
        
    }
    public void TakeScreenshot(Camera cam)
    {
        if(count >= 100)
        {
            ShowMaximumPictureNumberReached();
            controller.GetComponent<VibrateController>().VibrateStrong(1);
            return;
        }

        var currentRenderTexture = cam.targetTexture;
        RenderTexture newRenderTexture = new RenderTexture(originalRenderTexture);
        cam.targetTexture = newRenderTexture;
        cam.Render();
        GameObject rawImageCopy = GameObject.Instantiate(originalRawImage, content.transform);
        rawImageCopy.GetComponent<RawImage>().texture = newRenderTexture;
        rawImageCopy.SetActive(true);
        cam.targetTexture = currentRenderTexture;

        rawImageCopy.GetComponentInChildren<TextMeshProUGUI>().text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        count++;
    }

    public void HideMaximumPictureNumberReached()
    {
        maximumPictureNumberReached.SetActive(false);
    }

    public void ShowMaximumPictureNumberReached()
    {
        maximumPictureNumberReached.SetActive(true);
    }
}
