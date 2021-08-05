using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoExplanation4 : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("Explanation4");
        }
    }
}
