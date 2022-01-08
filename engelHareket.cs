using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelHareket : MonoBehaviour
{
 
    void FixedUpdate()
    {
        if(!dinoKotrol._olum)
        transform.Translate(Vector3.left*zemin._speed,Space.World);
        if(gameObject.transform.position.x<=-10f){
            Destroy(gameObject);
        }
    }
}
