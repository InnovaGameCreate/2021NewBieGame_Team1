using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class yokeru : MonoBehaviour
{
    // Start is called before the first frame update
    public int n, m;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        m = Random.Range(1, 5);
        n = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        //Debug.Log(b);
        //a =0;
        /*敵の入力を1~4の整数で入力してください*/


        //ここが自分の入力

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            n = 1;
            anim.SetBool("Is_right", true);
        }

        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            n = 2;
            anim.SetBool("Is_left", true);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            n = 3;
            anim.SetBool("Is_up", true);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            n = 4;
            anim.SetBool("Is_down", true);
        }

        //ここから別の処理で相手と自分の判定
        if (n != 0)
        {
            if (n == m)
            {
                //h = 2;
                  StartCoroutine("Lose");//����Lose�����Ă���

                Debug.Log("ここでがめおゔぇらのシーンに飛ぶ");
                //n = 0;

            }
            else if (n != m)
            {
                Debug.Log("ここでじゃんけんのシーンに飛ぶ");
                StartCoroutine("Win");//����Win�����Ă���

                //n = 0;
            }
        }


    }
    IEnumerator Win()
    {
        yield return new WaitForSeconds(1f);
      //  audioSource.PlayOneShot(sound2);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Zyanken");
        yield return new WaitForSeconds(1f);
        yield break;
    }
    IEnumerator Lose()
    {
        yield return new WaitForSeconds(1f);
        //audioSource.PlayOneShot(sound3);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Result");
        yield return new WaitForSeconds(1f);
        yield break;
    }

}
