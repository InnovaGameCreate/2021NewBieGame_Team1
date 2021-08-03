using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Data : MonoBehaviour
{
    public float score;
    // GameController�C���X�^���X�̎���
    private static Data instance = null;

    // GameController�C���X�^���X�̃v���p�e�B�[�́A���̂����݂��Ȃ��Ƃ��i������Q�Ǝ��j���̂�T���ēo�^����
    public static Data Instance => instance
        ?? (instance = GameObject.FindWithTag("Data").GetComponent<Data>());

    private void Awake()
    {
        // �����C���X�^���X���������݂���Ȃ�A�����j������
        if (this != Instance)
        {
            Destroy(this.gameObject);
            return;
        }
        // �B��̃C���X�^���X�Ȃ�A�V�[���J�ڂ��Ă��c��
        DontDestroyOnLoad(this.gameObject);
    }

    private void OnDestroy()
    {
        // �j�����ɁA�o�^�������̂̉������s��
        if (this == Instance) instance = null;
    }

    // ���Ƃ͂��D���Ȃ悤��
    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Zyanken")
        {
            score = 0;
        }
    }
}
