using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Zyanken : MonoBehaviour
{
    public float hand;
    public int enemy;
    
    public float iraira;//イライラゲージ
    public float irairaPerOnce;//イライラゲージの上昇量

    public bool one; //じゃんけんを一回のみ行う
    public bool phase;

    AudioSource audioSource;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;
    void Start()
    {
        one = false;
        phase = true;
        audioSource = GetComponent<AudioSource>();
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
                StartCoroutine("Win");//下のWinを見てくれ
                one = false;
                audioSource.PlayOneShot(sound1);
                phase = false;
            }
            if ((enemy - hand == 0) && (one == true))
            {
                StartCoroutine("Drow");
                one = false;//下のIEnumuratorを見てくれ。
                audioSource.PlayOneShot(sound1);
                phase = false;
            }
            if (((hand - enemy + 3) % 3 == 1) && (one == true))
            {
                StartCoroutine("Lose");//下のLoseを見てくれ
                one = false;
                audioSource.PlayOneShot(sound1);
                phase = false;
            }
        }
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(sound2);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("HOI");
        yield return new WaitForSeconds(1f);
        yield break;
    }

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(sound3);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Escape");
        yield return new WaitForSeconds(1f);
        yield break;
    }

    IEnumerator Drow()
    {
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(sound4);
        yield return new WaitForSeconds(0.5f);
        iraira = iraira + irairaPerOnce;
        GameObject director = GameObject.Find("IrairaDirector");
        director.GetComponent<IrairaDirector>().IncreaseIrairaGauge();
        yield return new WaitForSeconds(1f);
        phase = true;
        yield break;
    }
}
