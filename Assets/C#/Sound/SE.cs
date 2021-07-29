using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Component‚ğæ“¾
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // SpaceƒL[
        if (Input.GetKey(KeyCode.Space))
        {
            //SE‚ğ–Â‚ç‚·
            audioSource.PlayOneShot(sound1);
        } 
        else if (Input.GetKey(KeyCode.E))
        {
            audioSource.PlayOneShot(sound1);
        }
    }
}