using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGuu : MonoBehaviour
{
    public float loadTime;
    public GameObject Player;

    private bool oneAction;

    void Start()
    {
        transform.position = new Vector3(0, 30, -7);
        Player = GameObject.Find("player");
        oneAction = true;
    }

    void Update()
    {
        if ((Player.GetComponent<Zyanken>().enemy == 1) && (Player.GetComponent<Zyanken>().hand != 0) && (oneAction == true))
        {
            StartCoroutine("Count");
            oneAction = false;
        }
    }

    IEnumerator Count()
    {
        yield return new WaitForSeconds(0.5f);
        transform.position = new Vector3(0, 0, -7);
        yield return new WaitForSeconds(2f);
        transform.position = new Vector3(0, 30, -7);
        Player.GetComponent<Zyanken>().hand = 0;
        yield break;
    }
}
