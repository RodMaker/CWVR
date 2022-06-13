using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBounceAudio : MonoBehaviour
{
    public AudioSource audiosource;
    public AudioClip audioclip;
    
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter (Collision collision)
    {
        /*
        My Attempt
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
        if (collision.relativeVelocity.magnitude > 2)
            audiosource.PlayOneShot(audioclip);*/

        float volumeBall = rb.velocity.magnitude;
        if (volumeBall > 20)
            volumeBall = 20;
        audiosource.PlayOneShot(audioclip, volumeBall/20);
    }
}
