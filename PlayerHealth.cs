using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

    public int curHealth;
    public int maxHealth = 3;

    public GameObject Enemy; 
    void Start()
    {
        curHealth = maxHealth; 
    }

	void Update ()
    {
        if(curHealth > maxHealth)
        {
            curHealth = maxHealth; 
        }

        if(curHealth <= 0)
        {
            Die(); 
        }
	
	}

  /*  void OnTriggerEnter2D(Collider2D other)
    {
        if (other == Enemy.GetComponent<Collider2D>())
        {
            curHealth -= 1; 

        }
    }*/


    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            curHealth -= 1;
        }
    }


    void Die()
    {
        //Application.LoadLevel(Application.loadedLevel);
        Destroy(gameObject); 
    }
}
