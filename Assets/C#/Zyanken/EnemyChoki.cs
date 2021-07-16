using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChoki : MonoBehaviour
{
    public float loadTime;
    public GameObject Player;

    private bool oneAction;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-9, 30, 0);
        Player = GameObject.Find("player");
        oneAction = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)|| Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
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
        yield return new WaitForSeconds(1f);
        transform.position = new Vector3(-9, 0, 0);
        yield return new WaitForSeconds(3f);
        transform.position = new Vector3(-9, 30, 0);
        yield break;
    }
}
