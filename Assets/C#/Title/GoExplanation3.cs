using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GoExplanation3 : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("Explanation3");
        }
    }
}
