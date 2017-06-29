using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    private Vector3 Player;
    private Vector3 PlayerDir;     //Player direction  
    private float Xdif;            //Różnica odległości X
    private float Ydif;            //Różnica odległości Y
    
    public Rigidbody2D Enemy; 
    public float speed; 

    void Start()
    {
        speed = 1f; 
    }

	void Update ()
    {
        Player = GameObject.Find("Player").transform.position;

        Xdif = Player.x - transform.position.x;                     //różnica pozycji gracza od pozycji wroga
        Ydif = Player.y - transform.position.y;                     //pozwala obliczyć odległość wroga od gracza 

        PlayerDir = new Vector2(Xdif, Ydif);                        //przypisanie różnicy 


        Enemy.AddForce(PlayerDir.normalized * speed); 

	}

  
}
