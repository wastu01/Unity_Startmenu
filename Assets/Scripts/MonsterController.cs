using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
     

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += new Vector3(-Speed / 250, 0, 0);
    }
    
    
    //怪物攻擊動畫
    public void OnCollisionEnter2D(Collision2D collision)
    {
       
          if (collision.gameObject.name ==  "player(Clone)")

        {
             print("C:" + collision.gameObject.name); 
            
        this.gameObject.transform.position += new Vector3(0,0,0);

              Speed = 0;

    

        }


    }

    //執行怪物攻擊

    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name ==  "player(Clone)")
        {


            print("MonstererATK:" + collision.gameObject.name); 

        }
        
    }


}
