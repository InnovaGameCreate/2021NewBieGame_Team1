using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoExplanation2 : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
           FadeManager.FadeOut(2);
        }
    }
}
