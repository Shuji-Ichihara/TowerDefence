using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    [SerializeField] Image HpImage;
    [SerializeField] GameObject AttackRange;
    [SerializeField] LongChara LongChara;

    public int Hp;
    public float SaveTime;

    private bool attack;

    public enum CharaType
    {
        Attack,
        Defense,
        LongAttack,
    }

    public CharaType type = CharaType.Attack;

    void Start()
    {
        attack = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Hp <= 0)
        {
            HpImage.fillAmount = 0f;
            Destroy(gameObject);
        }

        if(!attack)
        {
            attack = true;
            if(type == CharaType.LongAttack)
            {
                LongChara.Attack();
            }
            AttackRange.SetActive(true);
            StartCoroutine("Attack");
        }
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(0.5f);

        AttackRange.SetActive(false);

        yield return new WaitForSeconds(SaveTime);

        attack = false;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy1")
        {
            Hp -= 20;
            switch(type)
            {
                case CharaType.Attack:
                    HpImage.fillAmount -= 0.25f;
                    break;
                case CharaType.Defense:
                    HpImage.fillAmount -= 0.15f;
                    break;
                case CharaType.LongAttack:
                    HpImage.fillAmount -= 0.5f;
                    break;
            }
        }
        else if (col.gameObject.tag == "Enemy2")
        {
            Hp -= 40;
            switch (type)
            {
                case CharaType.Attack:
                    HpImage.fillAmount -= 0.5f;
                    break;
                case CharaType.Defense:
                    HpImage.fillAmount -= 0.33f;
                    break;
                case CharaType.LongAttack:
                    HpImage.fillAmount -= 1f;
                    break;
            }
        }
        else if (col.gameObject.tag == "Enemy3")
        {
            Hp -= 10;
            switch (type)
            {
                case CharaType.Attack:
                    HpImage.fillAmount -= 0.125f;
                    break;
                case CharaType.Defense:
                    HpImage.fillAmount -= 0.083f;
                    break;
                case CharaType.LongAttack:
                    HpImage.fillAmount -= 0.25f;
                    break;
            }
        }
    }
}
