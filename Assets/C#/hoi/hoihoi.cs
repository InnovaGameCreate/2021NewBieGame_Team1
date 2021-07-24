using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoihoi : MonoBehaviour
{
    private Animator animator;
    public
        float impulse = 300;

    bool isCollision = false;

    Rigidbody rigidBody;
    Rigidbody playerRigidBody;
    GameObject player;

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();

        //プレイヤーをタグで検索し、Rigidbodyを取得
        player = GameObject.FindGameObjectWithTag("Player");
        playerRigidBody = player.GetComponent<Rigidbody>();
    }

    //衝突判定
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && isCollision == false)
        {
            //吹っ飛ばす
            Vector3 playerVelocity = playerRigidBody.velocity;
            rigidBody.AddForce(playerVelocity * impulse, ForceMode.Impulse);
            rigidBody.AddForce(Vector3.up * impulse, ForceMode.Impulse);

            isCollision = true;
        }
    }
    void SetKinematic(bool newValue)
    {
        Component[] components = GetComponentsInChildren(typeof(Rigidbody));

        foreach (Component c in components)
        {
            (c as Rigidbody).isKinematic = newValue;
        }
    }

    public void ChangeRagdoll()
    {
        SetKinematic(false);
        animator.SetTrigger("idle_enemy");
    }
}

