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
        yield return new WaitForSeconds(3f);
        transform.position = new Vector3(8, 0, 7);
        once = true;
        yield break;
    }
    IEnumerator Count()
    {
        yield return new WaitForSeconds(3f);
        once = true;
        yield break;
    }
}
