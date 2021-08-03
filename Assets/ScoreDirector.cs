using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreDirector : MonoBehaviour
{
    // GameController�C���X�^���X�̎���
    private static ScoreDirector instance = null;

    // GameController�C���X�^���X�̃v���p�e�B�[�́A���̂����݂��Ȃ��Ƃ��i������Q�Ǝ��j���̂�T���ēo�^����
    public static ScoreDirector Instance => instance
        ?? (instance = GameObject.FindWithTag("ScoreDirector").GetComponent<ScoreDirector>());

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
