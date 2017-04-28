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
<<<<<<< HEAD
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.magenta);
=======
        Debug.DrawRay(ray.origin, ray.direction * 20, Color.magenta);
>>>>>>> 3c7b6d3343df5b245af161e2cff832865c8b5921
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
