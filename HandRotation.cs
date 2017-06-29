using UnityEngine;
using System.Collections;

public class HandRotation : MonoBehaviour {

    public int rotationOffset;
    public float rotZ;
    public float rotX;
    public GameObject captain; 

	void Update ()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();

        rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        if(captain.GetComponent<Move>().transform.rotation.y != 0)
        {
            //rotZ = Mathf.Clamp(rotZ, -25, 32);
        }
        else
        {
            //rotZ = Mathf.Clamp(rotZ, -150, 150);
        }

        transform.rotation = Quaternion.Euler(rotX, 0f, rotZ + rotationOffset);
	}
}
