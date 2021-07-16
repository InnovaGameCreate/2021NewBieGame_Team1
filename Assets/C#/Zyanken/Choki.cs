using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choki : MonoBehaviour
{
    private const bool V = true;
    public GameObject Player;

    public bool once;
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
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
            {
                transform.position = new Vector3(10, 30, 0);
                StartCoroutine("CountChoki");
                once = false;
            }
            if(Input.GetKey(KeyCode.S))
            {
                once = false;
                StartCoroutine("Count");
            }
        }
    }

    IEnumerator CountChoki()
    {
        yield return new WaitForSeconds(4f);
        transform.position = new Vector3(10, 0, 0);
        once = true;
        yield break;
    }

    IEnumerator Count()
    {
        yield return new WaitForSeconds(4f);
        once = true;
        yield break;
    }
}
