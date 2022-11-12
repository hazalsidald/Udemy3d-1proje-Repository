using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using Udemy1proje.Inputs;
         //proje adý   //dosya adý
namespace Udemy1proje.Controllers //namespace nedir? classlarimizi birbirinden ayirma yöntemidir.//namespaceler proje adý ile olurlar.
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _force; //using.Systemden gelir.//serializefield?> force fieldimizi public yapmadan insceptorda gözukmesini saðlayan.
                                       //serialize hem private hem de sadece insceptordan eriþebilinirdir.

        Rigidbody _rigidbady;
        DeafultInput _input;//olusturdugum classým

        bool _isForceUp;

        private void Awake() //keþleme iþlemi
        {
           

            _rigidbady = GetComponent<Rigidbody>();//rigidbady companentini aliyorum//inspectordaki rigidbody referansini buraya alýyorruz.ve bilgilerine eriþiyoruz.
            _input= new DeafultInput();  //olusturdugum classýmý newledim
       
     
        }

        private void Update() //update ile input alýrýz.orneðin klavyeye bastým bu verileri update ile aliriz.//her bir fireymde bir çaliþir 1sn 30 60 120 çalýþýr anlamýna gelir.
        {
            Debug.Log(_input.IsForceUp);

          if(_input.IsForceUp) //input IsForceUp ise true/false
            {
                _isForceUp=true;    
            }
          else //deðilse
            {
                _isForceUp = false;
            }
            
                

        }

        private void FixedUpdate() //fixedupdate ile fizik iþlem yapariz. //standarttýr 0.2 sn çalýþýr.//fizik motoruylada sentiroze çalýþýr.
        {
            if(_isForceUp)//input IsForceUp ise bu iþlem olsun.
            {
                _rigidbady.AddForce(Vector3.up * Time.deltaTime*_force); //güç veriyoruz yukarý itme. 
                //fizik iþlemi demek yürüme olabilir collidor çarpmasý olabilir.
            }
        }


    }

}


