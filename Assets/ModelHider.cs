using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelHider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HideModel()
    {
        gameObject.SetActive(false);
    }
    public void ShowModel()
    {
        gameObject.SetActive(true);
    }


}
