using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackExplanation2 : MonoBehaviour
{
    void Update()
    {
         if(Input.GetKey(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene("Explanation2");
        }
    }
}
