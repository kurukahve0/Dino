using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engelKontrol : MonoBehaviour
{
    [SerializeField] GameObject[] kaktus; 
    [SerializeField] float _simdiZaman;
    private void kaktusBas(int a)
    {
        Instantiate(kaktus[a],transform.position,Quaternion.identity);
        
    }    
    void Update()
    {   if(!dinoKotrol._olum){
        if(_simdiZaman<=0){
            //Debug.Log("1");
            _simdiZaman=Random.Range(1.5f,2.7f);
            kaktusBas(Random.Range(0,3));

        }else{
            _simdiZaman-=Time.deltaTime;
        }
        }
    }

    
    
}
