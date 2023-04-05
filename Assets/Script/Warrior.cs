using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    public Vector2 Player;
    // Start is called before the first frame update
    void Start()
    {

    }

   // public void Dead()
    //{
      //  Destroy(gameObject);
   // }

  //  private void OnTriggerEnter2D(Collider2D collision)
  //  {
      //  if (collision.CompareTag("wall"))
      //  {
       //     Debug.Log("º®¿¡ ´ê¾Æ¼­ ¸äµÅÁö°¡ ³î¶ú½À´Ï´Ù.");
         //   Dead();
     //   }
 //   }

    // Update is called once per frame
    void Update()
    {
        Player = Vector2.zero;

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Player.x += 0.05f;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Player.x -= 0.05f;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Player.y += 0.05f;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Player.y -= 0.05f;
        }

        transform.Translate(Player);

    }
}
