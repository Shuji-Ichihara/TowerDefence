using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongChara : MonoBehaviour
{
    [SerializeField] GameObject AttackEria;

    public float AttackDis;

    private GameObject nearestEnemy;

    public void Attack()
    {
        nearestEnemy = null;
        //Enemyタグがついたオブジェクトをすべて配列に格納。
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemys)
        {
            //プレイヤーキャラと敵オブジェクトの距離の差を出す。
            float dis = Vector3.Distance(transform.position, enemy.transform.position);
            if (dis < AttackDis)    //範囲内か確認
            {
                //一番近い敵を代入
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null)
        {
            // 向きたい方向を計算
            Vector3 dir = (nearestEnemy.transform.position - transform.position);

            // ここで向きたい方向に回転させてます
            AttackEria.transform.rotation = Quaternion.FromToRotation(Vector3.up, dir);
        }
    }
}
