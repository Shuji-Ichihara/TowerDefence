using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillRcast : MonoBehaviour
{
    public Image imageComponent; // �t�F�[�h�C��������Image
    public ExsamplePlayre fadeFlags; // �t���O�Ǘ��X�N���v�g
    public float fadeDuration = 5f; // �t�F�[�h�ɂ����鎞��
    public int imageIndex; // �ΏۂƂȂ�Image�̔ԍ� (1�`3)

    public bool isFading = false; // �t�F�[�h�����ǂ����������t���O

    void Start()
    {
        // ���������x��ݒ� (���S�ɓ����ɂ���)
        Color color = imageComponent.color;
        color.a = 0f; // �ŏ��͊��S�ɓ����ɐݒ�
        imageComponent.color = color;
    }

    void Update()
    {
        // �t�F�[�h���łȂ��ꍇ�ɂ̂ݏ������s��
        if (!isFading)
        {
            switch (imageIndex)
            {
                case 1:
                    if (fadeFlags.fadeImage1) StartCoroutine(FadeIn());
                    break;
                case 2:
                    if (fadeFlags.fadeImage2) StartCoroutine(FadeIn());
                    break;
                case 3:
                    if (fadeFlags.fadeImage3) StartCoroutine(FadeIn());
                    break;
            }
        }
    }

    IEnumerator FadeIn()
    {
        isFading = true;  // �t�F�[�h���t���O�𗧂Ă�

        float elapsedTime = 0f;
        Color color = imageComponent.color;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / fadeDuration;

            color.a = Mathf.Lerp(0.5f, 0f, t);
            imageComponent.color = color;

            yield return null;
        }

        // �t�F�[�h�C��������ɓ����x��1�ɐݒ�
        color.a = 0f;
        imageComponent.color = color;
        isFading = false;  // �t�F�[�h������Ƀt���O��������
        if(fadeFlags.fadeImage1)
        {
            fadeFlags.fadeImage1 = false;
            Debug.Log("P1Cast");
        }
        if (fadeFlags.fadeImage2)
        {
            fadeFlags.fadeImage2 = false;
            Debug.Log("P1Cast2");
        }
        if (fadeFlags.fadeImage3)
        {
            fadeFlags.fadeImage3 = false;
            Debug.Log("P1Cast3");
        }
    }
}
