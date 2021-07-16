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
        transform.position = new Vector3(-9, 30, 0);
        Player = GameObject.Find("player");
        oneAction = true;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
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
        transform.position = new Vector3(-9, 0, 0);
        yield return new WaitForSeconds(3f);
        transform.position = new Vector3(-9, 30, 0);
        yield break;
;   }
}
