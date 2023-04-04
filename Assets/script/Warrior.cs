using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : MonoBehaviour
{
    public float speed = 5f; //Warrior �ӵ�

    private Rigidbody2D rb; 

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //����Ű�� ������ Warroir�� �̵�
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal, 5f);
        rb.velocity = movement * speed;
    }
    
    //// Start is called before the first frame update
 

}
