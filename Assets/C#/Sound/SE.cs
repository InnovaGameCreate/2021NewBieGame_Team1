using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Space�L�[
        if (Input.GetKey(KeyCode.Space))
        {
            //SE��炷
            audioSource.PlayOneShot(sound1);
        } 
        else if (Input.GetKey(KeyCode.E))
        {
            audioSource.PlayOneShot(sound1);
        }
    }
}