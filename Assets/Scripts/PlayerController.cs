using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    public int HP;
    public int ATK;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += new Vector3(Speed / 150, 0, 0);
    }

    //Player01攻擊動畫
    public void OnCollisionEnter2D(Collision2D OBJ)
    {
        if (OBJ.gameObject.name == "Monster(Clone)")
        {

            print("A:" + OBJ.gameObject.name);
            Speed = 0;

        }



    }

    //Player攻擊
    public void OnCollisionStay2D(Collision2D OBJ)
    {
        if (OBJ.gameObject.name == "Monster(Clone)")
        {

            print("PlayerATK:" + OBJ.gameObject.name);
        }

    }

    // void OnCollisionExit2D(Collision2D OBJ)
    // {
    //     print("C:" + OBJ.gameObject.name); //印出碰撞對象的名字
    // }
}
