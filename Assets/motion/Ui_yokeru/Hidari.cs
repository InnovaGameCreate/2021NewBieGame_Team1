using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidari : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      /*if(Input.GetKey(KeyCode.LeftArrow)){
      //this.gameObject.SetActive(false);
      }
      else{
          this.gameObject.SetActive(false);
      }*/
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.LeftArrow)){
        this.gameObject.SetActive(false);
      }
      /*else{
          this.gameObject.SetActive(false);
      }*/
    }
}
