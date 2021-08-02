using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM_Game : MonoBehaviour
{
    // GameController�C���X�^���X�̎���
    private static BGM_Game instance = null;

    // GameController�C���X�^���X�̃v���p�e�B�[�́A���̂����݂��Ȃ��Ƃ��i������Q�Ǝ��j���̂�T���ēo�^����
    public static BGM_Game Instance => instance
        ?? (instance = GameObject.FindWithTag("BGM_Game").GetComponent<BGM_Game>());

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
}
