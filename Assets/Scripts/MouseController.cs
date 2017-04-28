using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour {

    //Variables
    public LayerMask mask;
    Collectible inter;

 
    void Start () {
		
	}
	

	void Update ()
    {
        //Lanzamos continuamente un rayo para controlar la posicion del raton
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction, Mathf.Infinity, mask);

        //Pintamos el rayo
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.magenta);
        if (hit)
        {
            inter = hit.transform.GetComponent<Collectible>();
            if (inter)
            {
                Debug.Log(inter.PopUp());
                Destroy(inter.gameObject);
            }
        }
    }
}
