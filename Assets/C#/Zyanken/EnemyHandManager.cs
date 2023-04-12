using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHandManager : MonoBehaviour
{
    [SerializeField]
    GameObject enemyGuu;

    [SerializeField]
    GameObject enemyChoki;

    [SerializeField]
    GameObject enemyPaa;

    [SerializeField]
    Zyanken zyanken;

    void Awake()
    {
        enemyGuu.SetActive(false);
        enemyChoki.SetActive(false);
        enemyPaa.SetActive(false);
    }
    void Update()
    {
        if(zyanken.hand != 0)
        {
            if (zyanken.enemy == 1)
            {
                enemyGuu.SetActive(true);
                StartCoroutine("CoroutineTrigger");
                return;
            }

            if (zyanken.enemy == 2)
            {
                enemyChoki.SetActive(true);
                StartCoroutine("CoroutineTrigger");
                return;
            }
            if (zyanken.enemy == 3)
            {
                enemyPaa.SetActive(true);
                StartCoroutine("CoroutineTrigger");
                return;
            }
        }
    }

    IEnumerator CoroutineTrigger()
    {
        zyanken.hand = 0;
        yield return new WaitForSeconds(3.5f);
        enemyGuu.SetActive(false);
        enemyChoki.SetActive(false);
        enemyPaa.SetActive(false);
    }
}

