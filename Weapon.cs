using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

    public float fireRate = 0;
    public float damage = 10;
    public float counter; 
    public LayerMask whatToHit;

    public Transform BulletPrefab;
    public GameObject hand;
    public GameObject Enemy;
    public GameObject CounterText;                      

    float timeToFire = 0;
    Transform firePoint; 

	void Awake ()
    {
        counter = 0;                                    //Kill counter 

        firePoint = transform.FindChild("FirePoint"); 
        if(firePoint == null )
        {
            Debug.LogError("No firepoint !!!!!"); 
        }

	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(fireRate == 0)
        {
            if(Input.GetButtonDown("Fire1"))
            {
                Shoot(); 
            }
        }
        else
        {
            if(Input.GetButton("Fire1") && Time.time > timeToFire)
            {
                timeToFire = Time.time + 1 / fireRate;
                Shoot(); 
            }
        }
	}


    void Shoot()
    {
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 firePointPosition = new Vector2(firePoint.position.x, firePoint.position.y);
        RaycastHit2D hit = Physics2D.Raycast(firePointPosition, mousePosition-firePointPosition, 100, whatToHit);
        Effect();

        //Debug.DrawLine(firePointPosition, (mousePosition-firePointPosition)*1000, Color.cyan); 

      
        if (hit.collider.tag == "Enemy")
        {
            //Enemy.GetComponent<Rigidbody2D>().gravityScale = 1;
            //Enemy.GetComponent<Collider2D>().enabled = false;

            hit.collider.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
            hit.collider.gameObject.GetComponent<Collider2D>().enabled = false;
            Destroy(hit.collider.gameObject, 3.0f);
            counter++;
            CounterText.GetComponent<TextMesh>().text = counter.ToString(); 
            Debug.Log("hit");
        }

            
    }

    void Effect()
    {
        Instantiate(BulletPrefab, firePoint.position, firePoint.rotation);
    }

}
