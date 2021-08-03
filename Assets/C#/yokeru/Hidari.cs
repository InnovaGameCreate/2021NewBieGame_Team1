using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hidari : MonoBehaviour
{
    void Update()
    {
      if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.gameObject.SetActive(false);
        }
    }
}
