using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IrairaDirector : MonoBehaviour
{
    public Slider slider;
    Zyanken irairaGauge;
    // Start is called before the first frame update
    void Start()
    {
        irairaGauge = GameObject.Find("player").GetComponent <Zyanken>();
        slider.value = irairaGauge.iraira;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = irairaGauge.iraira;
    }
}
