using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {


	void Awake ()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("Music"); 
        if(objects.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject); 
	}
	

}
