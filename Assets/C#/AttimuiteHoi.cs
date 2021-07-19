using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoi : MonoBehaviour
{
  int a,b;
  //private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
      //anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          b=Random.Range(1,5);
          if(Input.GetKeyDown(KeyCode.LeftArrow)){
            a = 1;
            //anim.SetBool("左さす",true);
          }
          else if(Input.GetKeyDown(KeyCode.RightArrow)){
            a = 2;
            //anim.SetBool("右さす",true);
          }
          else if(Input.GetKeyDown(KeyCode.UpArrow)){
            a = 3;
            //anim.SetBool("上さす",true);
          }
          else if(Input.GetKeyDown(KeyCode.DownArrow)){
            a = 4;
            //anim.SetBool("下さす",true);
          }
        //}
          else  {
            Debug.Log("矢印を入力してください");
          }

          //ここから別の処理で相手と自分の判定
          if(a!=0){
          if(a==b){
            //h = 2;
            Debug.Log("ここで勝利？");
            a =0;

          }
          //ここは自分と相手が違う方向になった時
          else if(a!=b){
              Debug.Log("ここで何かが起きる");

              a = 0;
          }
        }
    }
}
