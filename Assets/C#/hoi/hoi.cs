using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hoi : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip way;
    public AudioClip punchSound;
    public AudioClip win;
    public AudioClip lose;

    private Animator anim;

    public int a, b;

    bool SE = true;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        b = Random.Range(1, 5);
        a = 0;
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            a = 1;
            audioSource.PlayOneShot(way);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            a = 2;
            audioSource.PlayOneShot(way);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            a = 3;
            audioSource.PlayOneShot(way);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            a = 4;
            audioSource.PlayOneShot(way);
        }

        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            SceneManager.LoadScene("Punch");
            audioSource.PlayOneShot(punchSound);
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            SceneManager.LoadScene("Punch");
            audioSource.PlayOneShot(punchSound);
        }
        //以下敵のアニメーション再生
        if (SE == true)
        {
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
                    
                    StartCoroutine("Win");
                    SE = false;
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

                    StartCoroutine("Lose");
                    SE = false;
                }
            }
        }
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(win);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Result");
        yield break;
    }

    IEnumerator Lose()
    {
        GameObject director = GameObject.Find("IrairaDirector");
        director.GetComponent<IrairaDirector>().IncreaseGauge();
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(lose);  
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Zyanken");
        yield break;
    }
}
