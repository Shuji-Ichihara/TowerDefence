using Cysharp.Threading.Tasks;
using UnityEngine;
using static SoundManager;


public class TestSoundManager : MonoBehaviour
{
    [SerializeField]
    private E_BGM _playBGM;


    void Update()
    {
        // U����������BGM���Đ�
        if (Input.GetKeyDown(KeyCode.U))
        {
            SoundManager.instance.PlayBGM(_playBGM, false);
        }
        // I����������t�F�[�h�A�E�g
        if (Input.GetKeyDown(KeyCode.I))
        {
            SoundManager.instance.FadeIOut(null, 3).Forget();
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            SoundManager.instance.PlaySE(SoundManager.E_SE.SE01);
        }

    }
}