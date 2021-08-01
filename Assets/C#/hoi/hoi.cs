using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hoi : MonoBehaviour
{
    public int a, b;
  　private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
      anim = gameObject.GetComponent<Animator>();
      b = Random.Range(1, 5);
      a = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            a = 1;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            a = 2;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            a = 3;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            a = 4;
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Debug.Log("右シフト");
            SceneManager.LoadScene("Punch");
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("左シフト");
            SceneManager.LoadScene("Punch");
        }
        //以下敵のアニメーション再生

        if (a != 0)
        {
            if (a == b)//勝利　ただしスコア0
            {
                if (b == 1)
                {
                    anim.SetBool("Is_right", true);
                }
                else if (b == 2)
                {
                    anim.SetBool("Is_left", true);
                }
                else if (b == 3)
                {
                    anim.SetBool("Is_up", true);
                }
                else if (b == 4)
                {
                    anim.SetBool("Is_down", true);
                }
                Debug.Log("勝利");
                StartCoroutine("Win");
            }
            
            else if (a != b)//敵に避けられた
            {
                //以下敵のアニメーション再生
                if (b == 1)
                {
                    anim.SetBool("Is_right", true);
                }
                else if (b == 2)
                {
                    anim.SetBool("Is_left", true);
                }
                else if (b == 3)
                {
                    anim.SetBool("Is_up", true);
                }
                else if (b == 4)
                {
                    anim.SetBool("Is_down", true);
                }
                //ここでイライラゲージが上昇する
                StartCoroutine("Lose");
            }
        }
    }
          //ここは自分と相手が違う方向になった時


    IEnumerator Win()
    {
        yield return new WaitForSeconds(1f);
        //  audioSource.PlayOneShot(sound2);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Result");
        yield return new WaitForSeconds(1f);
        yield break;
    }

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(1f);
        //audioSource.PlayOneShot(sound3);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Zyanken");
        yield return new WaitForSeconds(1f);
        yield break;
    }
}
