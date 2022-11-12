using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;
//yeni input sistemidir.
namespace Udemy1proje.Inputs
{
    public class DeafultInput // public class DeadultInput:MonoBehavior'a gerek yok normal bir class bu. 
   
    {
       
         DeafultAction _input; //DefaultAction, Input klasörunde bizim için oluþan classdýr. input burdan geliyor


    public bool IsForceUp { get; private set; } 

    public DeafultInput()
        {
            _input = new DeafultAction();//DefaultAction burda newliyorum.
            _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();//perfomed bu iþlem oldu perfonmasý göterdi bu bir eventtir.
            _input.Enable();                                                                      //action adýmýz rocket,//context parametre adýdýr.
                                                                                                  //ReadValueAsButton, bana true false döner.
        }





    } 


    
    
    
    
    
    
    
    }


