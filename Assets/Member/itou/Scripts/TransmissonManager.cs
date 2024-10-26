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
        SoundManager.instance.PlayBGM(SoundManager.E_BGM.Main);
    }

    // Update is called once per frame
    void Update()
    {
        if (_Hp <= 0)
        {
            Destroy(this.gameObject);
            SoundManager.instance.BGMPause();
            // ŽsŒ´’Ç‹L
            SceneChangeManager.Instacnce.ChangeScene(
                UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 2);
        }
    }
}
