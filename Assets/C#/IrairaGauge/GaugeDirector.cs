using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeDirector : MonoBehaviour
{
    private Image image;
    void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = GameObject.Find("IrairaDirector").GetComponent<IrairaDirector>().GetFillAmount();
    }
}
