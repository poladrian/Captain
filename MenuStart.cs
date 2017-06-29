using UnityEngine;
using System.Collections;

public class MenuStart : MonoBehaviour {

    void OnMouseOver()
    {
        GetComponent<GUIText>().color = new Color(1, 1, 1, 1);

        if (Input.GetButtonDown("Fire1"))
        {
            Application.LoadLevel("TestScene");
        }

    }

    void OnMouseExit()
    {

        GetComponent<GUIText>().color = new Color(0.3f, 0.3f, 0.3f, 1);

    }


}
