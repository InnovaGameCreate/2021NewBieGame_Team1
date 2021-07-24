using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IrairaDirector : MonoBehaviour
{
    GameObject gauge;

    Zyanken irairaGauge;
    // Start is called before the first frame update
    void Start()
    {
        irairaGauge = GameObject.Find("player").GetComponent <Zyanken>();
        gauge = GameObject.Find("Gauge");
        gauge.GetComponent<Image>().fillAmount = 0;
    }

    // Update is called once per frame
    public void IncreaseIrairaGauge()
    {
        this.gauge.GetComponent<Image>().fillAmount += 0.1f;
    }
}
