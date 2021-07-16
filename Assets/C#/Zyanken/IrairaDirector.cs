using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IrairaDirector : MonoBehaviour
{

    GameObject irairaGauge;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        irairaGauge = GameObject.Find("iraira");
    }

    // Update is called once per frame
    public void IncreaseGauge()
    {
        slider.value = irairaGauge.GetComponent<Zyanken>().iraira;
        Debug.Log(irairaGauge);
    }
}
