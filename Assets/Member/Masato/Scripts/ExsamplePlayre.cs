using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExsamplePlayre : MonoBehaviour
{
    // �eImage�ɑΉ�����t���O
    public bool fadeImage1;
    public bool fadeImage2;
    public bool fadeImage3;



    void Update()
    {
        // �Ⴆ�΁A�L�[���͂Ńt���O��؂�ւ���
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            fadeImage1 = true; // Image1���t�F�[�h�C��
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            fadeImage2 = true; // Image2���t�F�[�h�C��
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            fadeImage3 = true; // Image3���t�F�[�h�C��
        }
    }
}
