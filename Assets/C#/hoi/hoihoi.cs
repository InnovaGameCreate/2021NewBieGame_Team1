using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoihoi : MonoBehaviour
{
    public GameObject Enemy;                           // 生きているときのキャラクター
    public GameObject EnemyRagdoll;                    // 死んでいるときのキャラクター（ラグドール）
    private Animator animator;
    private Component[] components;
    public
        float impulse = 300;

    bool isCollision = false;

    Rigidbody rigidBody;
    Rigidbody playerRigidBody;
    GameObject player;
    Rigidbody enemyRigidBody;

    void Start()
    {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody>();
        components = GetComponentsInChildren(typeof(Rigidbody));
        Debug.Log("コンポーネント" + components.Length);

        Enemy.SetActive(true);            //生きているキャラクターオブジェクトをアクティブにする
        EnemyRagdoll.SetActive(false);         //死に用ラグドールキャラクターオブジェクトは非アクティブにしておく

        //プレイヤーをタグで検索し、Rigidbodyを取得
        player = GameObject.FindGameObjectWithTag("Player");
        playerRigidBody = player.GetComponent<Rigidbody>();
        
    }

    //衝突判定
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && isCollision == false)
        {
            Debug.Log("殴打");
            Enemy.SetActive(false);            //生きているキャラクターオブジェクトを非アクティブにする
            EnemyRagdoll.SetActive(true);         //死に用ラグドールキャラクターオブジェクトをアクティブ
            EnemyRagdoll.transform.position = Enemy.transform.position;
            
            Vector3 playerVelocity = playerRigidBody.velocity;            //吹っ飛ばす
            for (int i = 0; i < components.Length; i++)
            {
                //enemyRigidBody = components[i];
                enemyRigidBody.AddForce(playerVelocity * impulse, ForceMode.Impulse);
                enemyRigidBody.AddForce(Vector3.up * impulse, ForceMode.Impulse);
            }
            //rigidBody.AddForce(playerVelocity * impulse, ForceMode.Impulse);
            //rigidBody.AddForce(Vector3.up * impulse, ForceMode.Impulse);

            isCollision = true;
        }
       
    }

    void Update()
    {
        
    }
    /*void SetKinematic(bool newValue)
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
    }*/
}

