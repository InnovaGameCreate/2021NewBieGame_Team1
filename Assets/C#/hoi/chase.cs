using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chase : MonoBehaviour
{

    private GameObject player;   //�v���C���[���i�[�p
    private Vector3 offset;      //���΋����擾�p

    // Use this for initialization
    void Start()
    {

        //Enemy�̏����擾
        this.player = GameObject.Find("Spine");
       

        // MainCamera(�������g)��player�Ƃ̑��΋��������߂�
        offset = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        //�V�����g�����X�t�H�[���̒l��������
        transform.position = player.transform.position + offset;

    }
}

