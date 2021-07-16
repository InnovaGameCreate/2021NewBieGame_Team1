using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Zyanken : MonoBehaviour
{
    public float hand;
    public int enemy;
    
    public float iraira;//イライラゲージ
    public float irairaPerOnce;//イライラゲージの上昇量

    public bool one; //じゃんけんを一回のみ行う
    public bool phase;
    public Text message;

    void Start()
    {
        message.text = "じゃんけん";
        one = false;
        phase = true;
        iraira = 50;
    }

    // Update is called once per frame
    void Update()
    {
        if(phase == true)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                hand = 1;
                enemy = Random.Range(1, 4);
                one = true;
                message.text = "ぽん";
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                hand = 2;
                enemy = Random.Range(1, 4);
                one = true;
                message.text = "ぽん";
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                hand = 3;
                enemy = Random.Range(1, 4);
                one = true;
                message.text = "ぽん";
            }

            if (((hand - enemy + 3) % 3 == 2) && (one == true))
            {
                StartCoroutine("Win");//下のWinを見てくれ
                one = false;
                phase = false;
            }
            if ((enemy - hand == 0) && (one == true))
            {
                StartCoroutine("Drow");
                one = false;//下のIEnumuratorを見てくれ。
                phase = false;
            }
            if (((hand - enemy + 3) % 3 == 1) && (one == true))
            {
                StartCoroutine("Lose");//下のLoseを見てくれ
                one = false;
                phase = false;
            }
        }
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(2f);
        message.text = "あなたの勝ちです";
        yield return new WaitForSeconds(2f);
        yield break;
    }

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(2f);
        message.text = "あなたの負けです";
        yield return new WaitForSeconds(2f);
        yield break;
    }

    IEnumerator Drow()
    {
        yield return new WaitForSeconds(4f);
        message.text = "あいこで";
        iraira = iraira + 10;
        phase = true;
        yield break;
    }
}
