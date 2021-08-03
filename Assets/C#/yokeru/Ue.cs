using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ue : MonoBehaviour
{
    void Update()
    {
      if(Input.GetKey(KeyCode.UpArrow))
        {
            this.gameObject.SetActive(false);
        }
    }
}
