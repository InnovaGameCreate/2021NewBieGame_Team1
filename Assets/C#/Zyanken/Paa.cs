using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paa : MonoBehaviour
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
        if (once == true)
        {
            if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.position = new Vector3(-8, 30, 7);
                StartCoroutine("CountPaa");
                once = false;
            }
            if(Input.GetKey(KeyCode.RightArrow))
            {
                once = false;
                StartCoroutine("Count");
            }
        }
    }
    IEnumerator CountPaa()
    {
        yield return new WaitForSeconds(3f);
        transform.position = new Vector3(-8, 0, 7);
        once = true;
        yield break;
    }

    IEnumerator Count ()
    {
        yield return new WaitForSeconds(3f);
        once = true;
        yield break;
    }
}