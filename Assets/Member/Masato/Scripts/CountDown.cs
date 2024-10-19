using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField]
    private Text countdownText;  // TextオブジェクトをInspectorで設定
    private float timeRemaining = 60f;  // 60秒のカウントダウン
    private bool timerRunning = false;

    void Start()
    {
        // カウントダウンをスタート
        timerRunning = true;
    }

    void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                // 残り時間を減らす
                timeRemaining -= Time.deltaTime;
                // 残り時間をテキストに表示（秒単位で表示）
                countdownText.text = Mathf.Ceil(timeRemaining).ToString();
            }
            else
            {
                // カウントダウン終了時の処理
                timeRemaining = 0;
                timerRunning = false;
                countdownText.text = "Time's up!";
            }
        }
    }
}
