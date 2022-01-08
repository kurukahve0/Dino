using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIkontrol : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] TextMeshProUGUI _skotText;
    float skor;    
    bool alphaKontrol;

    
    void Start()
    {
        skor=1f;
        
        alphaKontrol=false;
       
        
    }


    void FixedUpdate()
    {
    if(!dinoKotrol._olum)  // text silme efekt
    {   skor += 0.15f;}
    
        if((((int)skor)%100==0 || alphaKontrol))
        {   alphaKontrol=true; 

            _skotText.alpha-=0.05f;
            _skotText.text=(Mathf.Floor((int)skor/100)*100).ToString();
            if(_skotText.alpha<=0.1f) alphaKontrol=false;
                                                                    
        }else 
        {              
            if(_skotText.alpha>=1){
            _skotText.text=((int)skor).ToString();

            }
            else{_skotText.alpha+=0.05f;
            _skotText.text=(Mathf.Floor((int)skor/100)*100).ToString();           
            } 
        }
        
    }

    public void gameOverUI(){
        SceneManager.LoadScene(0);
        
    }
}
