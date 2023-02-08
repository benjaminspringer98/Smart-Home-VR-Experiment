using UnityEngine;

public class UISoundPlayer : MonoBehaviour
{
    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySound(AudioClip sound)
    {
        audioSource.clip = sound;
        audioSource.Play();
    }
}
