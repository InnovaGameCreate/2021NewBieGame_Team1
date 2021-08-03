using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sita : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow))
        {
            this.gameObject.SetActive(false);
        }
    }
}
