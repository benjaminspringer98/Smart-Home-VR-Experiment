using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LogDisplayController : MonoBehaviour
{
    public GameObject loggerObject;
    public Logger logger;
    Canvas canvas;
    public GameObject content;
    public GameObject textObjectOriginal;
    TextMeshProUGUI textOriginal;
    public GameObject playerCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        logger = loggerObject.GetComponent<Logger>();
        textOriginal = textObjectOriginal.GetComponent<TextMeshProUGUI>();
        canvas = GetComponent<Canvas>();
        canvas.enabled = false;
        StartCoroutine(Delay());
    }

    // Update is called once per frame
    void Update()
    {
        if(canvas.enabled)
        {
            canvas.transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
            canvas.transform.position = new Vector3(transform.position.x, 1.25f, transform.position.z);
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(25);
        canvas.enabled = true;
        textOriginal.text += "Die folgenden Daten wurden am " + DateTime.Today.ToString("d") + " verarbeitet: \n";
       
        foreach( Log log in logger.logs)
        {
            GameObject textObjectCopy = GameObject.Instantiate(textObjectOriginal, content.transform);
            textObjectCopy.GetComponent<TextMeshProUGUI>().text = log.dateTime.ToString("HH:mm:ss") + ": " + log.text + "\n";
        }
    }
}
