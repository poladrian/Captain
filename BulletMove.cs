using UnityEngine;
using System.Collections;

public class BulletMove : MonoBehaviour {

    public int moveSpeed = 150; 
	
	
	void Update ()
    {
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed);
        Destroy(gameObject, 1);
	}

}
