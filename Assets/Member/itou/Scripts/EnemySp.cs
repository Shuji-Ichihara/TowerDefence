using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySp : MonoBehaviour
{
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject FighterPrefab;
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject ShielderPrefab;
    [SerializeField]
    [Tooltip("��������GameObject")]
    private GameObject ThiefPrefab;
    [SerializeField]
    [Tooltip("��������͈�A")]
    private Transform rangeA;
    [SerializeField]
    [Tooltip("��������͈�B")]
    private Transform rangeB;
    [SerializeField]
    private int Hani;

    int _randomenemy;
    // �o�ߎ���
    private float time;
    public float timeMax = 1f;

    // Update is called once per frame
    void Update()
    {
            // �O�t���[������̎��Ԃ����Z���Ă���
            time = time + Time.deltaTime;

            // ��1�b�u���Ƀ����_���ɐ��������悤�ɂ���B
            if (time > timeMax)
            {
                // rangeA��rangeB��x���W�͈͓̔��Ń����_���Ȑ��l���쐬
                float x = Random.Range(rangeA.position.x, rangeB.position.x);
                // rangeA��rangeB��y���W�͈͓̔��Ń����_���Ȑ��l���쐬
                float y = Random.Range(rangeA.position.y, rangeB.position.y);
                // GameObject����L�Ō��܂��������_���ȏꏊ�ɐ���
                _randomenemy = Random.Range(0, 3);
                while(-Hani <= x && x <= Hani && -Hani <= y && y <= Hani)
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

                // �o�ߎ��ԃ��Z�b�g
                time = 0f;
            }

    }
}
