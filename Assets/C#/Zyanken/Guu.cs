using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guu : MonoBehaviour
{
    public GameObject Player;
    private bool once;
    void Start()
    {
        Player = GameObject.Find("player");
        once = true;
    }

    void Update()
    {
        if ((once == true) && (Player.GetComponent<Zyanken>().hand != 0))
        {
            if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = new Vector3(8, 30, 7);
                StartCoroutine("CountGuu");
                once = false;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                once = false;
                StartCoroutine("Count");
            }
        }
    }

    IEnumerator CountGuu()
    {
        yield return new WaitForSeconds(3.5f);
        transform.position = new Vector3(8, 0, 7);
        once = true;
        yield break;
    }
    IEnumerator Count()
    {
        yield return new WaitForSeconds(3.5f);
        once = true;
        yield break;
    }
}
