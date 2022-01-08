using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class zemin : MonoBehaviour
{
   
   [SerializeField] static public float  _speed;   
   
   [SerializeField] GameObject _bulut,_kaya;
    
    void Start(){
        _speed=0.07f;
        InvokeRepeating("seviyeAyarı",30f,30f);
    }

    void seviyeAyarı(){
      if(!dinoKotrol._olum)
      _speed+=0.01f;
      Debug.Log(_speed);  
    }
    void FixedUpdate()
    {   if(!dinoKotrol._olum)
        {
            transform.Translate(Vector3.left*_speed,Space.World);
                if(transform.position.x<=-9f){
                transform.position=new Vector3(8.9f,transform.position.y,0f);
                }
            _bulut.gameObject.transform.Translate(Vector3.left*(_speed/6),Space.World);
                if(_bulut.transform.position.x<=-19f){
                _bulut.transform.position=new Vector3(0f,_bulut.transform.position.y,0f);
                }
            _kaya.gameObject.transform.Translate(Vector3.left*(_speed/3),Space.World);
                if(_kaya.transform.position.x<=-17.5f){
                _kaya.transform.position=new Vector3(0f,_kaya.transform.position.y,0f);
                }
        }
    }
   

    

}
