using System;
using System.Collections;
using UnityEngine;
using TMPro;

public class LogDisplayController : MonoBehaviour
{
    Canvas canvas;
    public GameObject scrollViewData;
    public GameObject scrollViewPictures;
    public GameObject scrollViewDataContent;
    public GameObject scrollViewPicturesContent;
    public GameObject textObjectOriginal;
    TextMeshProUGUI textOriginal;
    public GameObject textFinalObject;
    public GameObject firstButtonOriginal;
    public GameObject secondButtonOriginal;
    public GameObject xrRig;
    public GameObject loggerObject;
    public GameObject tabletUI;
    public Logger logger;

    // Start is called before the first frame update
    void Start()
    {
        logger = loggerObject.GetComponent<Logger>();
        textOriginal = textObjectOriginal.GetComponent<TextMeshProUGUI>();      
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        scrollViewPictures.SetActive(false);
        textFinalObject.SetActive(false);
        firstButtonOriginal.SetActive(false);
        
        StartCoroutine(Delay());
    }

    // Update is called once per frame
    void Update()
    {
        //if(canvas.enabled)
        //{
        //    canvas.transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        //    canvas.transform.position = new Vector3(transform.position.x, 1.25f, transform.position.z);
        //}
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(300);
        canvas.enabled = true;
        tabletUI.SetActive(false);
        xrRig.transform.position = new Vector3(1.75f, 0.00f, -0.5f);
        textOriginal.text += "Ihr Smart Home Security System hat am " + DateTime.Today.ToString("d") +
            " die folgenden Daten verarbeitet: \n";
       
        foreach( Log log in logger.logs)
        {
            GameObject textObjectCopy = GameObject.Instantiate(textObjectOriginal, scrollViewDataContent.transform);
            textObjectCopy.GetComponent<TextMeshProUGUI>().text = log.dateTime.ToString("HH:mm:ss") + ": " + log.text + "\n";
        }
        GameObject firstButtonCopy = GameObject.Instantiate(firstButtonOriginal, scrollViewDataContent.transform);
        firstButtonCopy.SetActive(true);
    }

    public void showSecondScreen()
    {
        scrollViewData.SetActive(false);
        scrollViewPictures.SetActive(true);

        GameObject secondButtonCopy = GameObject.Instantiate(secondButtonOriginal, scrollViewPicturesContent.transform);
        secondButtonOriginal.SetActive(false);
        secondButtonCopy.SetActive(true);
    }

    public void showFinalText()
    {
        scrollViewPictures.SetActive(false);
        textFinalObject.SetActive(true);
    }
}
