using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
If the tagName is not specified or the colliding gameobject has
a tag that matches the inputted tagName parameter, destroy colliding gameobject
*/
public class DestroyOnCollision : MonoBehaviour
{
    public string tagName;

    void OnTriggerEnter2D(Collider2D other){
      if(tagName == other.gameObject.tag || tagName == ""){
        Destroy(other.gameObject);
      }
    }

}
