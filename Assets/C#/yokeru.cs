using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokeru : MonoBehaviour
{
    // Start is called before the first frame update
    private int a, b, h;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      b=Random.Range(1,5);

      /*敵の入力を1~4の整数で入力してください*/

      //if (a==0){
      //ここが自分の入力
        if(Input.GetKey(KeyCode.LeftArrow)){
          a = 1;
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
          a = 2;
        }
        else if(Input.GetKey(KeyCode.UpArrow)){
          a = 3;
        }
        else if(Input.GetKey(KeyCode.DownArrow)){
          a = 4;
        }
      //}
        else {
          Debug.Log("矢印を入力してください");
        }
        //ここから別の処理で相手と自分の判定
        if(a==b){
          //h = 2;
          Debug.Log("ここでがめおゔぇら");


        }
        else if(a!=b){
            Debug.Log("ここでじゃんけん");


        }

        /*else{
          Debug.Log("矢印を入力してください");
        //  h = 1;
        }*/

    //return h;

    }
}