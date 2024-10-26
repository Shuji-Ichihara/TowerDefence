using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject Player1;
    [SerializeField] GameObject Player2;
    [SerializeField] GameObject Player3;

    public int MaxCount;

    //�ڎ���
    public bool fadeImage1;
    public bool fadeImage2;
    public bool fadeImage3;

    private int Count;

    public enum Chara
    {
        Player1,
        Player2,
        Player3,
    }

    public Chara character = Chara.Player1;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            character = Chara.Player1;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            character = Chara.Player2;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            character = Chara.Player3;
        }

        if (MaxCount > Count)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //�X�N���[�����W���烏�[���h���W�ɕϊ�
                Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                switch (character)
                {
                    case Chara.Player1:
                        if (!fadeImage1)
                        {
                            Instantiate(Player1, worldPoint, Quaternion.identity);
                            fadeImage1 = true; // Image1���t�F�[�h�C��
                        }
                        break;
                    case Chara.Player2:
                        if (!fadeImage2)
                        {
                            Instantiate(Player2, worldPoint, Quaternion.identity);
                            fadeImage2 = true; // Image2���t�F�[�h�C��
                        }
                        break;
                    case Chara.Player3:
                        if (!fadeImage3)
                        {
                            Instantiate(Player3, worldPoint, Quaternion.identity);
                            fadeImage3 = true; // Image3���t�F�[�h�C��
                        }
                        break;
                }
                Count++;

                /*
                //���C���΂�
                RaycastHit2D hit2d = Physics2D.Raycast(worldPoint, Vector2.zero);

                //�����蔻�肪���������ꍇ
                if (!hit2d)
                {
                    
                }

                */
            }
        }
    }
}
