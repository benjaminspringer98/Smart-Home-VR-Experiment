using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DoorController : MonoBehaviour
{
    public bool isLocked;
    public GameObject loggerObject;
    private AudioSource audioSource;
    Logger logger;
    Rigidbody rigidbody;
    public AudioClip unlockSound;
    public AudioClip lockSound;
    public GameObject doorNotClosedObject;
    public ActionBasedController controller;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        logger = loggerObject.GetComponent<Logger>();
        audioSource = GetComponent<AudioSource>();
        doorNotClosedObject.SetActive(false);
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
            doorNotClosedObject.SetActive(false);
            if (isLocked)
            {
                isLocked = false;
                audioSource.clip = unlockSound;
                audioSource.Play();
                logger.Add("Haustür <color=green>aufgeschlossen</color>");
            }
            else
            {
                isLocked = true;
                audioSource.clip = lockSound;
                audioSource.Play();
                logger.Add("Haustür <color=red>abgeschlossen</color>");
            }
                
        }
        else
        {
            doorNotClosedObject.SetActive(true);
            controller.GetComponent<VibrateController>().VibrateWeak(0.2f);
        }
            
       
    }
}
