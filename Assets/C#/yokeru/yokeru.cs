using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class yokeru : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip way;
    public AudioClip win;
    public AudioClip lose;

    public int n, m;
    private Animator anim;

    private bool SE;
    private bool oneAction;
    void Start()
    {
        anim = GetComponent<Animator>();
        m = Random.Range(1, 5);
        n = 0;
        audioSource = GetComponent<AudioSource>();
        SE = true;
        oneAction = true;
    }

    void Update()
    {
        //ここが自分の入力

        if (oneAction == true)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                n = 1;
                anim.SetBool("Is_right", true);
                audioSource.PlayOneShot(way);
            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                n = 2;
                anim.SetBool("Is_left", true);
                audioSource.PlayOneShot(way);
            }
            else if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                n = 3;
                anim.SetBool("Is_up", true);
                audioSource.PlayOneShot(way);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                n = 4;
                anim.SetBool("Is_down", true);
                audioSource.PlayOneShot(way);
            }

            //ここから別の処理で相手と自分の判定
            if (SE == true)
            {
                if (n != 0)
                {
                    if (n == m)
                    {
                        StartCoroutine("Lose");
                        SE = false;
                        oneAction = false;
                    }
                    else if (n != m)
                    {
                        StartCoroutine("Win");
                        SE = false;
                        oneAction = false;
                    }
                }
            }
        }
    }
    IEnumerator Win()
    {
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(win);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Zyanken");
        yield return new WaitForSeconds(1f);
        yield break;
    }
    IEnumerator Lose()
    {
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(lose);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Result");
        yield return new WaitForSeconds(1f);
        yield break;
    }
}
