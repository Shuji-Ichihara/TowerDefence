using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExsamplePlayre : MonoBehaviour
{
    // 各Imageに対応するフラグ
    public bool fadeImage1;
    public bool fadeImage2;
    public bool fadeImage3;



    void Update()
    {
        // 例えば、キー入力でフラグを切り替える
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            fadeImage1 = true; // Image1をフェードイン
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            fadeImage2 = true; // Image2をフェードイン
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            fadeImage3 = true; // Image3をフェードイン
        }
    }
}
