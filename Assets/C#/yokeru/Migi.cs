using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Migi : MonoBehaviour
{
    void Update()
    {
      if(Input.GetKey(KeyCode.RightArrow))
        {
            this.gameObject.SetActive(false);
        }
    }
}
