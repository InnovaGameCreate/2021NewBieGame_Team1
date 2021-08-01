using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ue : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKey(KeyCode.UpArrow)){
      this.gameObject.SetActive(false);
      }
      /*else{
          this.gameObject.SetActive(false);
      }*/
    }
}
