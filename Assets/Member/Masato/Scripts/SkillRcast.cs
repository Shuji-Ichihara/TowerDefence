using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SkillRcast : MonoBehaviour
{
    [SerializeField]
    private Image imageComponent; // フェードインさせるImage
    public PlayerController fadeFlags; // フラグ管理スクリプト
    [SerializeField]
    private float fadeDuration = 5f; // フェードにかける時間
    [SerializeField]
    private int imageIndex; // 対象となるImageの番号 (1～3)

    public bool isFading = false; // フェード中かどうかを示すフラグ

    void Start()
    {
        // 初期透明度を設定 (完全に透明にする)
        Color color = imageComponent.color;
        color.a = 0f; // 最初は完全に透明に設定
        imageComponent.color = color;
    }

    void Update()
    {
        // フェード中でない場合にのみ処理を行う
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
        isFading = true;  // フェード中フラグを立てる

        float elapsedTime = 0f;
        Color color = imageComponent.color;

        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float t = elapsedTime / fadeDuration;

            color.a = Mathf.Lerp(0.5f, 0.5f, t);
            imageComponent.color = color;

            yield return null;
        }

        // フェードイン完了後に透明度を1に設定
        color.a = 0f;
        imageComponent.color = color;
        isFading = false;  // フェード完了後にフラグを下げる
        if(fadeFlags.fadeImage1)
        {
            fadeFlags.fadeImage1 = false;
            Debug.Log("P1Cast");
        }
        if (fadeFlags.fadeImage2)
        {
            fadeFlags.fadeImage2 = false;
            Debug.Log("P2Cast");
        }
        if (fadeFlags.fadeImage3)
        {
            fadeFlags.fadeImage3 = false;
            Debug.Log("P3Cast");
        }
    }
}
