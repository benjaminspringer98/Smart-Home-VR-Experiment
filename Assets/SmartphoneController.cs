using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartphoneController : MonoBehaviour
{
    public bool isScreenOn;
    public GameObject ui;
    public GameObject defaultMenu;
    public GameObject activityDetectedDialogue;
    public GameObject display;
    DisplayController displayController;
    public GameObject currentMenu;
    // Start is called before the first frame update
    void Start()
    {
        activityDetectedDialogue.SetActive(false);
        displayController = display.GetComponent<DisplayController>();
    }

    // Update is called once per frame
    void Update()
    {
        renderScreen();
    }

    public void toggleScreen()
    {
        if (isScreenOn)
        {
            Debug.Log("turning screen off");
            isScreenOn = false;
        }

        else
        {
            Debug.Log("turning screen on");
            isScreenOn = true;
        }

    }

    void renderScreen()
    {
        if (isScreenOn)
        {
            ui.SetActive(true);
            displayController.TurnScreenOn();
        }
        else
        {
            ui.SetActive(false);
            displayController.TurnScreenOff();
        }
    }

    public void ShowActivityDetectedDialogue()
    {
        activityDetectedDialogue.SetActive(true);
    }

    public void HideActivityDetectedDialogue()
    {
        Debug.Log("Hiding activity diallgue");
        activityDetectedDialogue.SetActive(false);
    }

    public void HideDefaultMenu()
    {
        defaultMenu.SetActive(false);
    }

}
