using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExsamplePlayre : MonoBehaviour
{
    //※実験用の仮スクリプト
    // 各Imageに対応するフラグ(これで敵のスポーンリキャストを発生させる)
    public bool fadeImage1;
    public bool fadeImage2;
    public bool fadeImage3;



    void Update()
    {
        // 各兵士のスポーンキー
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

        if(Input.GetMouseButtonDown(0))
        {

        }
    }
}
