using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RagdollImpact : MonoBehaviour
{
    private Animator animator;
    public float impulse = 300;
    bool isCollision = false;
    Punch punch;

    Rigidbody rigidBody;
    Rigidbody playerRigidBody;
    GameObject Player;
    GameObject Field;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        Player = GameObject.FindGameObjectWithTag("Player");
        playerRigidBody = Player.GetComponent<Rigidbody>();
        punch = Player.GetComponent<Punch>();
        rigidBody.maxAngularVelocity = 100;
    }

    void Update()
    {
        int k = punch.k;
        int l = punch.l;




        if (k != 0)
        {
            if (k == l)
            {
                if (k == 1)
                {
                    animator.SetBool("Is_right", true);
                }
                else if (k == 2)
                {
                    animator.SetBool("Is_left", true);
                }
                else if (k == 3)
                {
                    animator.SetBool("Is_up", true);
                }
                else if (k == 4)
                {
                    animator.SetBool("Is_down", true);
                }
                //h = 2;
                StartCoroutine("Lose");

                k = 0;

            }
            else if (k != l)
            {
                if (k == 1)
                {
                    animator.SetBool("Is_right", true);
                }
                else if (k == 2)
                {
                    animator.SetBool("Is_left", true);
                }
                else if (k == 3)
                {
                    animator.SetBool("Is_up", true);
                }
                else if (k == 4)
                {
                    animator.SetBool("Is_down", true);
                }
                StartCoroutine("Win");

                k = 0;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.tag == "Player" && isCollision == false)
        {

            Vector3 playerVelocity = playerRigidBody.velocity;            //吹っ飛ばす
            rigidBody.AddForce(playerVelocity * ( impulse * 2 ), ForceMode.Impulse);
            rigidBody.AddForce(Vector3.up * ( impulse * 1 / 2 ), ForceMode.Impulse);
            rigidBody.AddForce(Vector3.back * (impulse * 1 / 2), ForceMode.Impulse);
            rigidBody.AddTorque(10, 10, 100, ForceMode.Force);


            isCollision = true;
        }

    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(1f);
        //  audioSource.PlayOneShot(sound2);
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("Result");
        yield return new WaitForSeconds(1f);
        yield break;
    }
    IEnumerator Lose()
    {
        yield return new WaitForSeconds(1f);
        //audioSource.PlayOneShot(sound3);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Result");
        yield return new WaitForSeconds(1f);
        yield break;
    }
}
