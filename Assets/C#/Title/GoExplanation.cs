using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoExplanation : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.E))
        {
           FadeManager.FadeOut(1);
        }
        
    }
}
