using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choki : MonoBehaviour
{
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
            if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.position = new Vector3(0, 30, 2);
                StartCoroutine("CountChoki");
                once = false;
            }
            if(Input.GetKey(KeyCode.UpArrow))
            {
                once = false;
                StartCoroutine("Count");
            }
        }
    }

    IEnumerator CountChoki()
    {
        yield return new WaitForSeconds(3.5f);
        transform.position = new Vector3(0, 0, 2);
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
