using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField]
    private Text countdownText;  // Text�I�u�W�F�N�g��Inspector�Őݒ�
    private float timeRemaining = 60f;  // 60�b�̃J�E���g�_�E��
    private bool timerRunning = false;

    void Start()
    {
        // �J�E���g�_�E�����X�^�[�g
        timerRunning = true;
    }

    void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                // �c�莞�Ԃ����炷
                timeRemaining -= Time.deltaTime;
                // �c�莞�Ԃ��e�L�X�g�ɕ\���i�b�P�ʂŕ\���j
                countdownText.text = Mathf.Ceil(timeRemaining).ToString();
            }
            else
            {
                // �J�E���g�_�E���I�����̏���
                timeRemaining = 0;
                timerRunning = false;
                countdownText.text = "Time's up!";
            }
        }
    }
}
