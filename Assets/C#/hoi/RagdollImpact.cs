using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RagdollImpact : MonoBehaviour
{
    private Animator animator;
    public float impulse = 300;
    public float magnification;

    public AudioClip lightPunch;
    public AudioClip heavyPunch;
    public AudioClip collisionSE;
    public AudioClip win;
    public AudioClip lose;
    AudioSource audioSource;

    Punch punch;

    Rigidbody rigidBody;
    Rigidbody playerRigidBody;

    [SerializeField] GameObject Player;
    GameObject Field;

    bool SE = true;
    bool isCollision = false;
    bool oneCoroutine = true;


    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        Field = GameObject.FindGameObjectWithTag("Field");
        playerRigidBody = Player.GetComponent<Rigidbody>();
        punch = Player.GetComponent<Punch>();
        rigidBody.maxAngularVelocity = 100;
        audioSource = GetComponent<AudioSource>();
        magnification = GameObject.Find("IrairaDirector").GetComponent<IrairaDirector>().power;
        int l = punch.l;
    }

    void Update()
    {
        if (magnification >= 3f)
        {
            magnification = 3f;
        }
        int k = punch.k;


        if (SE == true)
        {
            if (k != 0)
            {
                if (k == punch.l)
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
                    StartCoroutine("Lose");

                    k = 0;
                    SE = false;

                }
                else if (k != punch.l)
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
                    k = 0;
                    SE = false;
                }
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
            if (collision.gameObject.tag == "Player" && isCollision == false)
            {
                if (magnification < 0.4f)
                {
                    audioSource.PlayOneShot(lightPunch);
                }
                else if (magnification >= 0.4f)
                {
                    audioSource.PlayOneShot(heavyPunch);
                }
                Vector3 playerVelocity = playerRigidBody.velocity;            //吹っ飛ばす
                rigidBody.AddForce(playerVelocity * (impulse * 2) * magnification , ForceMode.Impulse);
                rigidBody.AddForce(Vector3.up * (impulse * 1 / 2)* magnification, ForceMode.Impulse);
                rigidBody.AddForce(Vector3.back * (impulse * 1 / 2) * magnification, ForceMode.Impulse);
                rigidBody.AddTorque(10f, 10f, 10f, ForceMode.Force);
                isCollision = true;
            }
            else if (collision.gameObject.tag == "Field" && isCollision == true)
            {
                audioSource.PlayOneShot(collisionSE);
                if (oneCoroutine == true)
                {
                    StartCoroutine("Win");
                    oneCoroutine = false;
                }
            }
    }

    IEnumerator Win()
    {
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(win);
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Result");
        yield return new WaitForSeconds(1f);
        yield break;
    }
    IEnumerator Lose()
    {
        yield return new WaitForSeconds(1f);
        audioSource.PlayOneShot(lose);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Result");
        yield return new WaitForSeconds(1f);
        yield break;
    }
}
