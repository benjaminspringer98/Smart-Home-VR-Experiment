using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSoundPlayer : MonoBehaviour
{
    private Rigidbody rigidBody;
    private AudioSource audioSource;

    [SerializeField] private AudioClip collisionSound;
    private float volumeSound;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        rigidBody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        volumeSound = rigidBody.velocity.magnitude; //maginitude converts velocity (Vector3) to a float. Refer to Unity API for more info

        audioSource.PlayOneShot(collisionSound, volumeSound);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
