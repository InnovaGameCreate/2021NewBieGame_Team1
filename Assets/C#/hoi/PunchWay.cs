using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PunchWay : MonoBehaviour
{
    public Image upPunchImage;
    public Image downPunchImage;
    public Image rightPunchImage;
    public Image leftPunchImage;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            upPunchImage.enabled = false;
            downPunchImage.enabled = false;
            rightPunchImage.enabled = false;
            leftPunchImage.enabled = false;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            upPunchImage.enabled = false;
            downPunchImage.enabled = false;
            rightPunchImage.enabled = false;
            leftPunchImage.enabled = false;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            upPunchImage.enabled = false;
            downPunchImage.enabled = false;
            rightPunchImage.enabled = false;
            leftPunchImage.enabled = false;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            upPunchImage.enabled = false;
            downPunchImage.enabled = false;
            rightPunchImage.enabled = false;
            leftPunchImage.enabled = false;
        }
    }
}
