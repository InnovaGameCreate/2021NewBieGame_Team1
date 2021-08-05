using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPaa : MonoBehaviour
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
        if ((Player.GetComponent<Zyanken>().enemy == 3) && (Player.GetComponent<Zyanken>().hand != 0) && (oneAction == true) )
        {
            StartCoroutine("Count");
            oneAction = false;
        }
    }

    IEnumerator Count()
    {
        yield return new WaitForSeconds(0.5f);
        transform.position = new Vector3(0, 0, -7);
        yield return new WaitForSeconds(2.5f);
        transform.position = new Vector3(0, 30, -7);
        yield return new WaitForSeconds(0.5f);
        Player.GetComponent<Zyanken>().hand = 0;
        oneAction = true;
        Player.GetComponent<Zyanken>().enemy = Random.Range(1, 4);
        yield break;
    }
}
