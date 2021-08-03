using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChoki : MonoBehaviour
{
    public float loadTime;
    public GameObject Player;

    private bool oneAction;
    void Start()
    {
        transform.position = new Vector3(0, 30, -7);
        Player = GameObject.Find("player");
        oneAction = false;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow)|| Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            oneAction = true;
        }
        if (Player.GetComponent<Zyanken>().enemy == 2 && oneAction == true)
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
        transform.position = new Vector3(0, 30,-7);
        yield break;
    }
}
