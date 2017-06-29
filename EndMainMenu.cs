using UnityEngine;
using System.Collections;

public class EndMainMenu : MonoBehaviour {

    void OnMouseOver()
    {
        GetComponent<GUIText>().color = new Color(1, 1, 1, 1);

        if (Input.GetButtonDown("Fire1"))
        {
            Application.LoadLevel("Menu");
        }

    }

    void OnMouseExit()
    {

        GetComponent<GUIText>().color = new Color(0, 0, 0, 1);

    }

}
