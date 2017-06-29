using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

    public GameObject target;
    public Vector2 offset;


    void Update ()
    {
        Vector3 targetposition = new Vector3(target.transform.position.x + offset.x, target.transform.position.y + offset.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, targetposition, 0.05f);

    }
}
