using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : Objects {

    GameObject container;
<<<<<<< HEAD
    public GameObject prefab;

    void Start()
    {
      
    }
   
	
	void Update ()
    {
=======

    void Start()
    {
>>>>>>> 3c7b6d3343df5b245af161e2cff832865c8b5921
        container = FindObjectOfType<Objects>().gameObject;
    }
}
