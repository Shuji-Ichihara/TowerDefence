using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] GameObject Player1;
    [SerializeField] GameObject Player2;
    [SerializeField] GameObject Player3;

    public int MaxCount;

    private int Count;

    public enum Chara
    {
        Player1,
        Player2,
        Player3,
    }

    public Chara character = Chara.Player1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

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
                //スクリーン座標からワールド座標に変換
                Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                //レイを飛ばす
                RaycastHit2D hit2d = Physics2D.Raycast(worldPoint, Vector2.zero);

                //当たり判定が無かった場合
                if (!hit2d)
                {
                    switch(character)
                    {
                        case Chara.Player1:
                            Instantiate(Player1, worldPoint, Quaternion.identity);
                            break;
                        case Chara.Player2:
                            Instantiate(Player2, worldPoint, Quaternion.identity);
                            break;
                        case Chara.Player3:
                            Instantiate(Player3, worldPoint, Quaternion.identity);
                            break;
                    }
                    Count++;
                }
            }
        }
    }
}
