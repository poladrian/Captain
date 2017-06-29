using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public float speed;
    public int jump;
    public GameObject hand;
    public SpriteRenderer gun;

    Animator anim; 

    public Rigidbody2D Captain;

    void Start()
    {
        //Capitain = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>(); 
    }
	
	void Update ()
    {
        Vector2 moveDir = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Captain.velocity.y);
        Captain.velocity = moveDir;

        if(Input.GetAxisRaw("Horizontal") == 1)
        {      
            transform.right = Vector2.left;
           
            anim.SetBool("Speed", true);
            anim.SetBool("Ground", true);
        }
        else if(Input.GetAxisRaw("Horizontal") == -1 )
        {
            transform.right = Vector2.right;
            
            anim.SetBool("Speed", true);
            anim.SetBool("Ground", true);
        }
        else
        {
            anim.SetBool("Speed", false);
        }

        //Jeśli Kapitan obróci się w prawo - ten warunek pozwala na utrzymanie reki w odpowiedniej pozycji 
        if (Captain.transform.rotation.y != 0)
        {
            hand.GetComponent<HandRotation>().transform.rotation = Quaternion.Euler(180f, hand.GetComponent<HandRotation>().transform.rotation.y, -(hand.GetComponent<HandRotation>().rotZ + hand.GetComponent<HandRotation>().rotationOffset));
        }

        if (Input.GetKeyDown(KeyCode.W) && Captain.velocity.y == 0)
        {
            Captain.AddForce(new Vector2(0, jump));
            anim.SetBool("Ground", false);
        }
        else
        {
            anim.SetBool("Ground", true); 
        }

    }
}
