using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Punch : MonoBehaviour
{
    // Start is called before the first frame update
    public int k, l;
    private Animator anim;
    Rigidbody rigidBody;
    GameObject Player;

    void Start()
    {
        anim = GetComponent<Animator>();
        l = Random.Range(1, 5);
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {


        //Debug.Log(b);
        //k =0;
        /*敵の入力を1~4の整数で入力してください*/


        //ここが自分の入力

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            k = 1;
            anim.SetBool("is_rightHook", true);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            k = 2;
            anim.SetBool("is_leftHook", true);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            k = 3;
            anim.SetBool("is_upperCut", true);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            k = 4;
            anim.SetBool("is_crossPunch", true);
        }

        else
        {
            //Debug.Log("矢印を入力してください");
            anim.SetBool("is_rightHook", false);
            anim.SetBool("is_leftHook", false);
            anim.SetBool("is_upperCut", false);
            anim.SetBool("is_crossPunch", false);
        }

        //ここから別の処理で相手と自分の判定
        if (k != 0)
        {
            if (k == l)
            {
                if (k == 1)
                {
                    Debug.Log("うんち");
                    rigidBody.AddForce(Vector3.left * 100, ForceMode.Impulse);
                }
                else if (k == 2)
                {
                    Debug.Log("うんち");
                    rigidBody.AddForce(Vector3.right * 100, ForceMode.Impulse);
                }
                else if (k == 3)
                {
                    Debug.Log("うんち");
                    rigidBody.AddForce(Vector3.up * 100, ForceMode.Impulse);
                }
                else if (k == 4)
                {
                    Debug.Log("うんち");
                    rigidBody.AddForce(Vector3.forward * 100, ForceMode.Impulse);
                }
            }
        }
    }
}
