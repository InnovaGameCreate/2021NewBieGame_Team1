using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Zyanken : MonoBehaviour
{
    public float hand;
    public int enemy;
    
    public float iraira;//�C���C���Q�[�W
    public float irairaPerOnce;//�C���C���Q�[�W�̏㏸��

    public bool one; //����񂯂�����̂ݍs��
    public bool phase;
    void Start()
    {
        one = false;
        phase = true;
        iraira = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if(phase == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                hand = 1;
                enemy = Random.Range(1, 4);
                one = true;
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                hand = 2;
                enemy = Random.Range(1, 4);
                one = true;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                hand = 3;
                enemy = Random.Range(1, 4);
                one = true;
            }

            if (((hand - enemy + 3) % 3 == 2) && (one == true))
            {
                StartCoroutine("Win");//����Win�����Ă���
                one = false;
                phase = false;
            }
            if ((enemy - hand == 0) && (one == true))
            {
                StartCoroutine("Drow");
                one = false;//����IEnumurator�����Ă���B
                phase = false;
            }
            if (((hand - enemy + 3) % 3 == 1) && (one == true))
            {
                StartCoroutine("Lose");//����Lose�����Ă���
                one = false;
                phase = false;
            }
        }
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("HOI");
        yield return new WaitForSeconds(2f);
        yield break;
    }

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Escape");
        yield return new WaitForSeconds(2f);
        yield break;
    }

    IEnumerator Drow()
    {
        yield return new WaitForSeconds(4f);
        iraira = iraira + 10;
        phase = true;
        yield break;
    }
}
