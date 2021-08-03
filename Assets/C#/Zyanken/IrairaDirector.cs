using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class IrairaDirector : MonoBehaviour
{
    private static IrairaDirector instance = null;

    static public GameObject gauge;
    static public float fillAmount = 0.0f;
    private Image image;
    private Image picture;

    public float power = 0.1f;

    Zyanken irairaGauge;

    void Awake ()
    {

        SceneManager.sceneLoaded += SetComponent ;
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void SetComponent(Scene S,LoadSceneMode mode )
    { 
        gauge = GameObject.Find("Gauge");
        if(gauge != null)
        {
            image = gauge.GetComponent<Image>();
            image.fillAmount = fillAmount;
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
        power += 0.1f;
    }
    public void IncreaseGauge()
    {
        image.fillAmount += 0.05f;
        fillAmount = image.fillAmount;
        power += 0.05f;
    }

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Result")
        {
            power = 0.1f;
            fillAmount = 0.0f;
        }
    }
}
