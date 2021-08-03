using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE_Explanation : MonoBehaviour
{
     float reload;
    
     float reloadTime2;
    AudioSource audioSource;

    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
       reload = 1f;
       reloadTime2 = 0.1f;
    }

    void Update()
    {
        if (reloadTime2 < reload)
        {
            reloadTime2 = reloadTime2 + Time.deltaTime;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            audioSource.Play();
            reloadTime2=0f;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            audioSource.Play();
            reloadTime2=0f;
        }
    }       
} 