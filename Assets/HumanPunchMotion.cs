using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanPunchMotion : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up")) //↑入力でアッパーカット
        {
            animator.SetBool("is_upperCut", true);
        }
        else
        {
            animator.SetBool("is_upperCut", false);
        }

        if (Input.GetKey("right")) //→入力で左フック
        {
            animator.SetBool("is_leftHook", true);
        }
        else
        {
            animator.SetBool("is_leftHook", false);
        }

        if (Input.GetKey("left")) //←入力で右フック
        {
            animator.SetBool("is_rightHook", true);
        }
        else
        {
            animator.SetBool("is_rightHook", false);
        }

        if (Input.GetKey("down")) //↓入力でクロスパンチ
        {
            animator.SetBool("is_crossPunch", true);
        }
        else
        {
            animator.SetBool("is_crossPunch", false);
        }

    }
}
