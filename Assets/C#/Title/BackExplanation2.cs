using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackExplanation2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("pushButton");
            SceneManager.LoadScene("Explanation2");
        }
    }
}