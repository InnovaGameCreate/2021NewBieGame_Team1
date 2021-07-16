using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guu : MonoBehaviour
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
        if(once == true)
        {
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
            {
                transform.position = new Vector3(14, 30, 0);
                StartCoroutine("CountGuu");
                once = false;
            }
            if (Input.GetKey(KeyCode.A))
            {
                once = false;
                StartCoroutine("Count");
            }
        }
    }

    IEnumerator CountGuu()
    {
        yield return new WaitForSeconds(4f);
        transform.position = new Vector3(14, 0, 0);
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
