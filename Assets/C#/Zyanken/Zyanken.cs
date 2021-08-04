using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Zyanken : MonoBehaviour
{
    public int hand;
    public int enemy;

    private bool one; 

    AudioSource audioSource;
    public AudioClip sound1;
    public AudioClip sound2;
    public AudioClip sound3;
    public AudioClip sound4;

    void Start()
    {
        one = false;
        audioSource = GetComponent<AudioSource>();
        enemy = Random.Range(1, 4);
        hand = 0;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            hand = 1;
            one = true;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            hand = 2;
            one = true;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            hand = 3;
            one = true;
        }
        if (hand != 0)
        {
            if ((hand == 1) && (enemy == 1) && (one == true))
            {
                StartCoroutine("Drow");
                one = false;
                audioSource.PlayOneShot(sound1);
            }
            else if (hand == 1 && enemy == 2 && (one == true))
            {
                StartCoroutine("Win");
                one = false;
                audioSource.PlayOneShot(sound1);
            }
            else if (hand == 1 && enemy == 3 && (one == true))
            {
                StartCoroutine("Lose");
                one = false;
                audioSource.PlayOneShot(sound1);
            }
            else if (hand == 2 && enemy == 1 && (one == true))
            {
                StartCoroutine("Lose");
                one = false;
                audioSource.PlayOneShot(sound1);
            }
            else if (hand == 2 && enemy == 2 && (one == true))
            {
                StartCoroutine("Drow");
                one = false;
                audioSource.PlayOneShot(sound1);
            }
            else if (hand == 2 && enemy == 3 && (one == true))
            {
                StartCoroutine("Win");
                one = false;
                audioSource.PlayOneShot(sound1);
            }
            else if (hand == 3 && enemy == 1&& (one == true))
            {
                StartCoroutine("Win");
                one = false;
                audioSource.PlayOneShot(sound1);
            }
            else if (hand == 3 && enemy == 2 && (one == true))
            {
                StartCoroutine("Lose");
                one = false;
                audioSource.PlayOneShot(sound1);
            }
            else if (hand == 3 && enemy == 3 && (one == true))
            {
                StartCoroutine("Drow");
                one = false;
                audioSource.PlayOneShot(sound1);
            }
        }
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(1.0f);
        audioSource.PlayOneShot(sound2);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("HOI");
        yield break;
    }

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(1.0f);
        audioSource.PlayOneShot(sound3);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Escape");
        yield break;
    }

    IEnumerator Drow()
    {
        yield return new WaitForSeconds(1.0f);
        audioSource.PlayOneShot(sound4);
        yield return new WaitForSeconds(0.5f);
        GameObject director = GameObject.Find("IrairaDirector");
        director.GetComponent<IrairaDirector>().IncreaseIrairaGauge();
        yield return new WaitForSeconds(1.5f);
        enemy = Random.Range(1, 4);
        yield break;
    }
}
