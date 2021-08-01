using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_hoi : MonoBehaviour
{
    public Image upImage;
    public Image downImage;
    public Image rightImage;
    public Image leftImage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            upImage.enabled = false;
            downImage.enabled = false;
            rightImage.enabled = false;
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            upImage.enabled = false;
            downImage.enabled = false;
            leftImage.enabled = false;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            downImage.enabled = false;
            rightImage.enabled = false;
            leftImage.enabled = false;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            upImage.enabled = false;
            rightImage.enabled = false;
            leftImage.enabled = false;
        }
    }
}
