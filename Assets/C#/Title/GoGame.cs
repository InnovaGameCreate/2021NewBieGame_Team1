using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoGame : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            FadeManager.FadeOut(10);
        }
        if (Input.GetKey(KeyCode.Q))
        {
            Application.Quit();
        }
    }
}
