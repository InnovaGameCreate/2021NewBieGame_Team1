using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyGuu : MonoBehaviour
{
    public Zyanken enemyhand;
    public GameObject Player;
    public float loadTime;

    private bool oneAction;
    void Start()
    {
        transform.position = new Vector3(0, 30, -7);
        Player = GameObject.Find("player");
        oneAction = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            oneAction = true;
        }
        if (Player.GetComponent<Zyanken>().enemy ==1 && oneAction == true)
        {
            StartCoroutine("Count");
            oneAction = false;
        }
    }

    IEnumerator Count()
    {
        yield return new WaitForSeconds(1f);
        transform.position = new Vector3(0, 0, -7);
        yield return new WaitForSeconds(3f);
        transform.position = new Vector3(0, 30, -7);
        yield break;
;   }
}
