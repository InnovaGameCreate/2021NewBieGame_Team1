using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Migi : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.RightArrow)){
      this.gameObject.SetActive(false);
      }
      /*else{
          this.gameObject.SetActive(false);
      }*/
    }
}
