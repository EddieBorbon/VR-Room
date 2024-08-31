using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSound : MonoBehaviour
{
    public AudioClip collisionSound;
    private AudioSource audioSource;
    private Rigidbody rb;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.spatialBlend = 1.0f; // 3D sound
        audioSource.rolloffMode = AudioRolloffMode.Linear;
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Calculate volume based on the ball's speed
        float speed = rb.velocity.magnitude;
        float volume = Mathf.Clamp(speed / 10f, 0.1f, 1.0f); // Adjust the divisor as needed

        audioSource.PlayOneShot(collisionSound, volume);
    }
}
