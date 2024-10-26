using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class EnemyManager : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject _Transmission;
    public GameObject _Player;
    private GameObject _Enemy;
    private TransmissonManager _TransmissonManager;
    public bool _Playerdetection = false;
    private float _Speed;
    private int _Hp;
    void Start()
    {
        _Enemy = this.gameObject;
        if (_Enemy.name == "Fighter")
        {
            _Hp = 120;
            _Speed = 0.5f;
        }
        else if(_Enemy.name == "Shielder")
        {
            _Hp = 180;
            _Speed = 0.3f;
        }
        else if (_Enemy.name == "Thief")
        {
            _Hp = 60;
            _Speed = 0.7f;
        }
        _Transmission = GameObject.FindGameObjectWithTag("Transmission");
        _TransmissonManager = _Transmission.GetComponent<TransmissonManager>();
    }

    // Update is called once per frame
    void Update()
    {
        //HPが1以上だったら伝書に向かって移動
        if (_Hp > 0)
        {
            if(_Playerdetection == false)
            {
                transform.position = Vector2.MoveTowards(
                transform.position,
                new Vector2(_Transmission.transform.position.x, _Transmission.transform.position.y),
                _Speed * Time.deltaTime);
            }
            else if(_Playerdetection == true)
            {
                transform.position = Vector2.MoveTowards(
                transform.position,
                new Vector2(_Player.transform.position.x, _Player.transform.position.y),
                _Speed * Time.deltaTime);
            }
        }
        // HPが0以下だったら自身を削除
        else if (_Hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Transmission"))
        {
            _TransmissonManager._Hp--;
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.CompareTag("Attack1"))
        {
            SoundManager.instance.PlaySE(SoundManager.E_SE.Damage);
            _Hp -= 60;
        }
        if (other.gameObject.CompareTag("Attack2"))
        {
            SoundManager.instance.PlaySE(SoundManager.E_SE.Damage);
            _Hp -= 30;
        }
        if (other.gameObject.CompareTag("Attack3"))
        {
            SoundManager.instance.PlaySE(SoundManager.E_SE.Damage);
            _Hp -= 120;
        }
    }
}
