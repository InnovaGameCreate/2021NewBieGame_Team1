using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{

    public AudioClip sound1;
    AudioSource audioSource;

    private bool once;

    void Start()
    {
        //Componentを取得
        once = true;
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Spaceキー
        if (Input.GetKey(KeyCode.Space) || once == true)
        {
            //SEを鳴らす
            audioSource.PlayOneShot(sound1);
            once = false;

        } 

        if (Input.GetKey(KeyCode.E) || once == true)
        {
            audioSource.PlayOneShot(sound1);
            once = false;
        }
    }
}