using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Punch : MonoBehaviour
{
    public int k, l;
    private Animator anim;
    public GameObject BGM_Game;
    public AudioClip way;

    Rigidbody rigidBody;
    GameObject Player;
    AudioSource audioSource;

    bool SE = true;

    void Start()
    {
        l = Random.Range(1, 5);
        this.gameObject.SetActive(false);
        anim = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        BGM_Game = GameObject.FindWithTag("BGM_Game");
        Destroy(BGM_Game);

    }

    // Update is called once per frame
    void Update()
    {
        if (SE == true)
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                k = 1;
                anim.SetBool("is_rightHook", true);
                audioSource.PlayOneShot(way);
                SE = false;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                k = 2;
                anim.SetBool("is_leftHook", true);
                audioSource.PlayOneShot(way);
                SE = false;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                k = 3;
                anim.SetBool("is_upperCut", true);
                audioSource.PlayOneShot(way);
                SE = false;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                k = 4;
                anim.SetBool("is_crossPunch", true);
                audioSource.PlayOneShot(way);
                SE = false;
            }
        }


        //ここから別の処理で相手と自分の判定
        if (k != 0)
        {
            if (k == l)
            {
                if (k == 1)
                {
                    rigidBody.AddForce(Vector3.left *10, ForceMode.Impulse);
                }
                else if (k == 2)
                {
                    rigidBody.AddForce(Vector3.right * 10, ForceMode.Impulse);
                }
                else if (k == 3)
                {
                    rigidBody.AddForce(Vector3.up * 10, ForceMode.Impulse);
                }
                else if (k == 4)
                {
                    rigidBody.AddForce(Vector3.forward *10, ForceMode.Impulse);
                }
            }
        }
    }
}
