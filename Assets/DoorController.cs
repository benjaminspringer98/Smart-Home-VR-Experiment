using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool isLocked;
    public GameObject loggerObject;
    Logger logger;
    Rigidbody rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        logger = loggerObject.GetComponent<Logger>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isLocked)
            rigidbody.constraints = RigidbodyConstraints.FreezePosition;
        else
            rigidbody.constraints = RigidbodyConstraints.None;
    }

    public bool IsClosed()
    {
        return transform.localEulerAngles.y < 0.1;
    }

    public void ToggleLock()
    {
        if(IsClosed())
        {
            if (isLocked)
            {
                isLocked = false;
                logger.Add("Haustür <color=green>aufgeschlossen</color>");
            }
            else
            {
                isLocked = true;
                logger.Add("Haustür <color=red>abgeschlossen</color>");
            }
                
        }
            

    }
}
