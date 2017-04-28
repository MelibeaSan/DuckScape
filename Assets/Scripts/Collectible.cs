using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : Objects {

    GameObject container;
    public GameObject prefab;

    void Start()
    {
      
    }
   
	
	void Update ()
    {
        container = FindObjectOfType<Objects>().gameObject;
    }
}
