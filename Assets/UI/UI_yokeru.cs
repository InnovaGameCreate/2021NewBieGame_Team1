using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_yokeru : MonoBehaviour
{
    public Image UpImage;
    public Image DownImage;
    public Image RightImage;
    public Image LeftImage;
    public Image FingerUpImage;
    public Image FingerDownImage;
    public Image FingerRightImage;
    public Image FingerLeftImage;
    yokeru Yokeru;
    GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        FingerUpImage.enabled = false;
        FingerDownImage.enabled = false;
        FingerRightImage.enabled = false;
        FingerLeftImage.enabled = false;
        Player = GameObject.FindGameObjectWithTag("Player");
        Yokeru = Player.GetComponent<yokeru>();
    }

    // Update is called once per frame
    void Update()
    {
        int n = Yokeru.n;
        int m = Yokeru.m;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (m == 1)
            {
                FingerLeftImage.enabled = true;
            }
            else if (m == 2)
            {
                FingerRightImage.enabled = true;
            }
            else if (m == 3)
            {
                FingerUpImage.enabled = true;
            }
            else if (m == 4)
            {
                FingerDownImage.enabled = true;
            }
            UpImage.enabled = false;
            DownImage.enabled = false;
            RightImage.enabled = false;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (m == 1)
            {
                FingerLeftImage.enabled = true;
            }
            else if (m == 2)
            {
                FingerRightImage.enabled = true;
            }
            else if (m == 3)
            {
                FingerUpImage.enabled = true;
            }
            else if (m == 4)
            {
                FingerDownImage.enabled = true;
            }
            UpImage.enabled = false;
            DownImage.enabled = false;
            LeftImage.enabled = false;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            if (m == 1)
            {
                FingerLeftImage.enabled = true;
            }
            else if (m == 2)
            {
                FingerRightImage.enabled = true;
            }
            else if (m == 3)
            {
                FingerUpImage.enabled = true;
            }
            else if (m == 4)
            {
                FingerDownImage.enabled = true;
            }
            DownImage.enabled = false;
            RightImage.enabled = false;
            LeftImage.enabled = false;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            if (m == 1)
            {
                FingerLeftImage.enabled = true;
            }
            else if (m == 2)
            {
                FingerRightImage.enabled = true;
            }
            else if (m == 3)
            {
                FingerUpImage.enabled = true;
            }
            else if (m == 4)
            {
                FingerDownImage.enabled = true;
            }
            UpImage.enabled = false;
            RightImage.enabled = false;
            LeftImage.enabled = false;
        }

        
    }
}
