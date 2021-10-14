using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandManager : MonoBehaviour
{
    [SerializeField]
    GameObject guu;

    [SerializeField]
    GameObject choki;

    [SerializeField]
    GameObject paa;

    [SerializeField]
    Zyanken zyanken;
    void Start()
    {
        guu.SetActive(true);
        choki.SetActive(true);
        paa.SetActive(true);
    }

    void Update()
    {
        if(zyanken.isAbleToZyanken == false)
        {
            if (zyanken.hand == 1)
            {
                ActiveGuu();
            }
            if (zyanken.hand == 2)
            {
                ActiveChoki();
            }
            if (zyanken.hand == 3)
            {
                ActivePaa();
            }
        }
        else
        {
            ActiveAll();
        }
    }

    void ActiveGuu()
    {
        guu.SetActive(true);
        choki.SetActive(false);
        paa.SetActive(false);
    }
    void ActiveChoki()
    {
        guu.SetActive(false);
        choki.SetActive(true);
        paa.SetActive(false);
    }
    void ActivePaa()
    {
        guu.SetActive(false);
        choki.SetActive(false);
        paa.SetActive(true);
    }
    void ActiveAll()
    {
        guu.SetActive(true);
        choki.SetActive(true);
        paa.SetActive(true);
    }
}
