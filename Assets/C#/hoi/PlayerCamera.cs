using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public GameObject MainCamera;      //���C���J�����i�[�p
    public GameObject SubCamera;       //�T�u�J�����i�[�p 
    public GameObject puncher;

    void Start()
    {
        MainCamera.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            puncher.SetActive(true);
            MainCamera.SetActive(true);
            SubCamera.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            puncher.SetActive(true);
            MainCamera.SetActive(true);
            SubCamera.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            puncher.SetActive(true);
            MainCamera.SetActive(true);
            SubCamera.SetActive(false);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            puncher.SetActive(true);
            MainCamera.SetActive(true);
            SubCamera.SetActive(false);
        }
    }
}
