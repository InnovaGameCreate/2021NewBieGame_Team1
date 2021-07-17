using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paa : MonoBehaviour
{
    public GameObject Player;
    private bool once;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("player");
        once = true;
    }

    // Update is called once per frame
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
        yield return new WaitForSeconds(4f);
        transform.position = new Vector3(-8, 0, 7);
        once = true;
        yield break;
    }

    IEnumerator Count ()
    {
        yield return new WaitForSeconds(4f);
        once = true;
        yield break;
    }
}