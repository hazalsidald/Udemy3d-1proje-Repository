using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System;
using Udemy1proje.Inputs;
         //proje ad�   //dosya ad�
namespace Udemy1proje.Controllers //namespace nedir? classlarimizi birbirinden ayirma y�ntemidir.//namespaceler proje ad� ile olurlar.
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _force; //using.Systemden gelir.//serializefield?> force fieldimizi public yapmadan insceptorda g�zukmesini sa�layan.
                                       //serialize hem private hem de sadece insceptordan eri�ebilinirdir.

        Rigidbody _rigidbady;
        DeafultInput _input;//olusturdugum class�m

        bool _isForceUp;

        private void Awake() //ke�leme i�lemi
        {
           

            _rigidbady = GetComponent<Rigidbody>();//rigidbady companentini aliyorum//inspectordaki rigidbody referansini buraya al�yorruz.ve bilgilerine eri�iyoruz.
            _input= new DeafultInput();  //olusturdugum class�m� newledim
       
     
        }

        private void Update() //update ile input al�r�z.orne�in klavyeye bast�m bu verileri update ile aliriz.//her bir fireymde bir �ali�ir 1sn 30 60 120 �al���r anlam�na gelir.
        {
            Debug.Log(_input.IsForceUp);

          if(_input.IsForceUp) //input IsForceUp ise true/false
            {
                _isForceUp=true;    
            }
          else //de�ilse
            {
                _isForceUp = false;
            }
            
                

        }

        private void FixedUpdate() //fixedupdate ile fizik i�lem yapariz. //standartt�r 0.2 sn �al���r.//fizik motoruylada sentiroze �al���r.
        {
            if(_isForceUp)//input IsForceUp ise bu i�lem olsun.
            {
                _rigidbady.AddForce(Vector3.up * Time.deltaTime*_force); //g�� veriyoruz yukar� itme. 
                //fizik i�lemi demek y�r�me olabilir collidor �arpmas� olabilir.
            }
        }


    }

}


