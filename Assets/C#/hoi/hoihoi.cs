using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoihoi : MonoBehaviour
{
    public GameObject Enemy;                           // �����Ă���Ƃ��̃L�����N�^�[
    public GameObject EnemyRagdoll;                    // ����ł���Ƃ��̃L�����N�^�[�i���O�h�[���j
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
        Debug.Log("�R���|�[�l���g" + components.Length);

        Enemy.SetActive(true);            //�����Ă���L�����N�^�[�I�u�W�F�N�g���A�N�e�B�u�ɂ���
        EnemyRagdoll.SetActive(false);         //���ɗp���O�h�[���L�����N�^�[�I�u�W�F�N�g�͔�A�N�e�B�u�ɂ��Ă���

        //�v���C���[���^�O�Ō������ARigidbody���擾
        player = GameObject.FindGameObjectWithTag("Player");
        playerRigidBody = player.GetComponent<Rigidbody>();
        
    }

    //�Փ˔���
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" && isCollision == false)
        {
            Debug.Log("����");
            Enemy.SetActive(false);            //�����Ă���L�����N�^�[�I�u�W�F�N�g���A�N�e�B�u�ɂ���
            EnemyRagdoll.SetActive(true);         //���ɗp���O�h�[���L�����N�^�[�I�u�W�F�N�g���A�N�e�B�u
            EnemyRagdoll.transform.position = Enemy.transform.position;
            
            Vector3 playerVelocity = playerRigidBody.velocity;            //������΂�
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

