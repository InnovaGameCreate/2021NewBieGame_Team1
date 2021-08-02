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
    public int a, b;
    public GameObject data;
    private Animator anim;
    bool SE = true;
    public Data dataCs;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        b = Random.Range(1, 5);
        a = 0;
        audioSource = GetComponent<AudioSource>();
        data = GameObject.Find("Data");
        dataCs = data.GetComponent<Data>();
    }

    // Update is called once per frame
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
            Debug.Log("右シフト");
            SceneManager.LoadScene("Punch");
            audioSource.PlayOneShot(punchSound);
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("左シフト");
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

                    //ここでイライラゲージが上昇する

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
        dataCs.score = 0;
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Result");
        yield return new WaitForSeconds(1f);
        yield break;
    }

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(lose);
        
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Zyanken");
        yield return new WaitForSeconds(1f);
        yield break;
    }
}
