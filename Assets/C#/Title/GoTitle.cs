using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoTitle : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.T))
        {
            SceneManager.LoadScene("Title");
        }
    }
}
