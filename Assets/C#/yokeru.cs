using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yokeru : MonoBehaviour
{
    // Start is called before the first frame update
    private int a, b;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      b=Random.Range(1,5);


    //ここが自分の避けるむきの入力をする場所
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
          a = 1;
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow)){
          a = 2;
        }
        else if(Input.GetKeyDown(KeyCode.UpArrow)){
          a = 3;
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow)){
          a = 4;
        }
      //}
        else  {
          Debug.Log("矢印を入力してください");
        }

        //ここから別の処理で相手と自分の判定
        if(a!=0){
        if(a==b){
          //h = 2;
          Debug.Log("ここでがめおゔぇらのシーンに飛ぶ");
          a =0;

        }
        else if(a!=b){
            Debug.Log("ここでじゃんけんのシーンにとぶ");

            a = 0;
        }
      }


    }
}
