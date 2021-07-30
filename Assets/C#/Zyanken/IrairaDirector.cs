using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IrairaDirector : MonoBehaviour
{
    public GameObject gauge;
    private float fillAmount;
    private Image image;

    Zyanken irairaGauge;

    // Start is called before the first frame update
    void Start()
    {
        fillAmount = 0.0f;
        irairaGauge = GameObject.Find("player").GetComponent <Zyanken>();
        gauge = GameObject.Find("Gauge");
        image = gauge.GetComponent<Image>();
        image.fillAmount = 0.0f;
        DontDestroyOnLoad(this.gameObject);
        Debug.Log("aaa");
    }

    // Update is called once per frame
    public void IncreaseIrairaGauge()
    {
        image.fillAmount += 0.1f;
        fillAmount = image.fillAmount;
    }

    public float GetFillAmount()
    {
        return fillAmount;
    }
}
