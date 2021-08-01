using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sita : MonoBehaviour
{
    // Start is called before the first frame update
    //public class Sita : MonoBehaviour
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.DownArrow)){
        this.gameObject.SetActive(false);
        }
        /*else{
            this.gameObject.SetActive(false);
        }*/
    }
}
