using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySp : MonoBehaviour
{
    [SerializeField, Tooltip("生成するGameObject")]
    private GameObject FighterPrefab;
    [SerializeField, Tooltip("生成するGameObject")]
    private GameObject ShielderPrefab;
    [SerializeField, Tooltip("生成するGameObject")]
    private GameObject ThiefPrefab;
    [SerializeField, Tooltip("生成する範囲A")]
    private Transform rangeA = null;
    [SerializeField, Tooltip("生成する範囲B")]
    private Transform rangeB = null;
    [SerializeField]
    private int Hani;

    int _randomenemy;
    // 経過時間
    private float time;
    public float timeMax = 5f;

    // Update is called once per frame
    void Update()
    {
        // 前フレームからの時間を加算していく
        time = time + Time.deltaTime;

        // 約1秒置きにランダムに生成されるようにする。
        if (time > timeMax)
        {
            // rangeAとrangeBのx座標の範囲内でランダムな数値を作成
            float x = Random.Range(rangeA.position.x, rangeB.position.x);
            // rangeAとrangeBのy座標の範囲内でランダムな数値を作成
            float y = Random.Range(rangeA.position.y, rangeB.position.y);
            // GameObjectを上記で決まったランダムな場所に生成
            _randomenemy = Random.Range(0, 3);
            while (-Hani <= x && x <= Hani && -Hani <= y && y <= Hani)
            {
                x = Random.Range(rangeA.position.x, rangeB.position.x);
                y = Random.Range(rangeA.position.y, rangeB.position.y);
            }
            if (_randomenemy == 0)
            {
                var enemy = Instantiate(FighterPrefab, new Vector2(x, y), FighterPrefab.transform.rotation);
                enemy.name = FighterPrefab.name;
            }
            else if (_randomenemy == 1)
            {
                var enemy = Instantiate(ShielderPrefab, new Vector2(x, y), ShielderPrefab.transform.rotation);
                enemy.name = ShielderPrefab.name;
            }
            else if (_randomenemy == 2)
            {
                var enemy = Instantiate(ThiefPrefab, new Vector2(x, y), ThiefPrefab.transform.rotation);
                enemy.name = ThiefPrefab.name;
            }

            // 経過時間リセット
            time = 0f;
        }

    }
}
