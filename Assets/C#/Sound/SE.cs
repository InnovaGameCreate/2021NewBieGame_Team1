using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SE : MonoBehaviour
{
     float reload;
     float reloadTime1;
     float reloadTime2;
    AudioSource audioSource;

    void Start()
    {
        //Component???
        audioSource = GetComponent<AudioSource>();
       reload = 1f;
       reloadTime1 = 0.5f;
       //reloadTime2 = 0.1f;
    }

    void Update()
    {
        if (reloadTime1 < reload)
        {
            reloadTime1 = reloadTime1 + Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            audioSource.Play();
            reloadTime1 = 0f;
        }
        /*else if(Input.GetKey(KeyCode.E))
            {
                audioSource.Play();
                reloadTime1=0f;
            }

            if(reloadTime2<reload)
            {
                reloadTime2 = reloadTime2 + Time.deltaTime;
            }
          else if(Input.GetKey(KeyCode.RightArrow))
            {
                audioSource.Play();
                reloadTime2=0f;
            }
          else if(Input.GetKey(KeyCode.LeftArrow))
            {
                audioSource.Play();
                reloadTime2=0f;
            }  */
    }       
} 