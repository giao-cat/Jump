using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
	 private Rigidbody2D rb;
     private Animator anim;

     public Collider2D coll;
     public float speed;
     public float jumpforce;
     public LayerMask ground;
   
   
    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
		float horizontalmove = Input.GetAxis("Horizontal");
        float facedircetion = Input.GetAxisRaw("Horizontal");
		//角色移动
        if (horizontalmove != 0)
        {
            rb.velocity = new Vector2(horizontalmove*speed * Time.deltaTime, rb.velocity.y);
        }
        if(facedircetion != 0)
        {
            transform.localScale = new Vector3(facedircetion, 1, 1);
        }
        
    }
}
