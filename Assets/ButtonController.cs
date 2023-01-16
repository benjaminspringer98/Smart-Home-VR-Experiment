using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Sprite spriteLocked;
    public Sprite spriteUnlocked;
    public GameObject door;
    DoorController doorController;
    Image image;
    // Start is called before the first frame update
    void Start()
    {
        doorController = door.GetComponent<DoorController>();
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if(doorController.isLocked)
        {
            image.sprite = spriteLocked;
        }
        else
        {
            image.sprite = spriteUnlocked;
        }
    }
}
