using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmissonManager : MonoBehaviour
{
    public int _Hp;
    // Start is called before the first frame update
    void Start()
    {
        _Hp = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if(_Hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
