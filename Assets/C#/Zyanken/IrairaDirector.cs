using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IrairaDirector : MonoBehaviour
{
    static public GameObject gauge;
    static public float fillAmount;
    private Image image;
    private Image picture;
    public bool first = false;

    Zyanken irairaGauge;
    void Awake()
    {
        if (!first)
        {
            fillAmount = 0.0f;
            irairaGauge = GameObject.Find("player").GetComponent<Zyanken>();
            gauge = GameObject.Find("Gauge");
            image = gauge.GetComponent<Image>();
            image.fillAmount = 0.0f;
            DontDestroyOnLoad(this.gameObject);
            first = true;
        }
        else
        {
            irairaGauge = GameObject.Find("player").GetComponent<Zyanken>();
        }
    }

    public float GetFillAmount()
    {
        return image.fillAmount;
    }
    public void IncreaseIrairaGauge()
    {
        image.fillAmount += 0.1f;
        fillAmount = image.fillAmount;
    }
    private void Update()
    {
        image = gauge .GetComponent<Image>();
    }
}
