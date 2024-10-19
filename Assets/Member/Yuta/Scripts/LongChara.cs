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
        //Enemy�^�O�������I�u�W�F�N�g�����ׂĔz��Ɋi�[�B
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        foreach (GameObject enemy in enemys)
        {
            //�v���C���[�L�����ƓG�I�u�W�F�N�g�̋����̍����o���B
            float dis = Vector3.Distance(transform.position, enemy.transform.position);
            if (dis < AttackDis)    //�͈͓����m�F
            {
                //��ԋ߂��G����
                nearestEnemy = enemy;
            }
        }

        if (nearestEnemy != null)
        {
            // ���������������v�Z
            Vector3 dir = (nearestEnemy.transform.position - transform.position);

            // �����Ō������������ɉ�]�����Ă܂�
            AttackEria.transform.rotation = Quaternion.FromToRotation(Vector3.up, dir);
        }
    }
}
