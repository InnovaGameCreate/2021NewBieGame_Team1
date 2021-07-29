using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Spaceキー
        if (Input.GetKey(KeyCode.Space))
        {
            //SEを鳴らす
            audioSource.PlayOneShot(sound1);
        } 
        else if (Input.GetKey(KeyCode.E))
        {
            audioSource.PlayOneShot(sound1);
        }
    }
}