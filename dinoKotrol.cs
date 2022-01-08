using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dinoKotrol : MonoBehaviour
{
    Rigidbody2D rb;

    [SerializeField] float _jumpSpeed;
    [SerializeField] GameObject _gameOverObject;
    Animator anim;

    bool _zeminDokunma;

    public static bool _olum;

    [SerializeField] AudioClip _jumpKlip,_olKlip;
    AudioSource audioDino ;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
        audioDino=GetComponent<AudioSource>();
        Time.timeScale=1.7f;
        _olum=false;
    }

    
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && _zeminDokunma && !_olum){
            rb.AddForce(Vector2.up*_jumpSpeed,ForceMode2D.Impulse);
            _zeminDokunma=false;
            anim.SetBool("jump",true);
            audioDino.PlayOneShot(_jumpKlip);
        }else if(_olum){ rb.velocity=Vector2.zero; rb.gravityScale=0f;} 
    }

    void OnCollisionEnter2D(Collision2D col){
        
        if(col.gameObject.CompareTag("zemin"))
        {
        _zeminDokunma= true;
        anim.SetBool("jump",false);
        }
        
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("engel")){
           anim.SetTrigger("ol");
            _olum=true;
            _gameOverObject.SetActive(true);
            audioDino.PlayOneShot(_olKlip);
        }
    }
    
    
}
