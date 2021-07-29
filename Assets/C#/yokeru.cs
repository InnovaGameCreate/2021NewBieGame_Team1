using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokeru : MonoBehaviour
{
    // Start is called before the first frame update
    private int a, b;
    private Animator anim;

    void Start()
    {
      anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      b=Random.Range(1,5);
      //Debug.Log(b);
      //a =0;
      /*敵の入力を1~4の整数で入力してください*/


      //ここが自分の入力

        if(Input.GetKey(KeyCode.LeftArrow)){
          a = 1;
          anim.SetBool("Is_right",true);
        }

        else if(Input.GetKey(KeyCode.RightArrow)){
          a = 2;
          anim.SetBool("Is_left",true);
        }
        else if(Input.GetKey(KeyCode.UpArrow)){
          a = 3;
          anim.SetBool("Is_up",true);
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
          a = 4;
          anim.SetBool("Is_down",true);
        }

        else  {
          //Debug.Log("矢印を入力してください");
          anim.SetBool("Is_left",false);
          anim.SetBool("Is_right",false);
          anim.SetBool("Is_up",false);
          anim.SetBool("Is_down",false);
        }

        //ここから別の処理で相手と自分の判定
        if(a!=0){
        if(a==b){
          //h = 2;
          Debug.Log("ここでがめおゔぇらのシーンに飛ぶ");
          a =0;

        }
        else if(a!=b){
            Debug.Log("ここでじゃんけんのシーンに飛ぶ");

            a = 0;
        }
      }


    }
}
