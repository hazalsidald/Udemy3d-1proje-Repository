using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;
//yeni input sistemidir.
namespace Udemy1proje.Inputs
{
    public class DeafultInput // public class DeadultInput:MonoBehavior'a gerek yok normal bir class bu. 
   
    {
       
         DeafultAction _input; //DefaultAction, Input klas�runde bizim i�in olu�an classd�r. input burdan geliyor


    public bool IsForceUp { get; private set; } 

    public DeafultInput()
        {
            _input = new DeafultAction();//DefaultAction burda newliyorum.
            _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();//perfomed bu i�lem oldu perfonmas� g�terdi bu bir eventtir.
            _input.Enable();//bu olmay�nca �al��m�yor.                                            //action ad�m�z rocket,//context parametre ad�d�r.
                                                                                                  //ReadValueAsButton, bana true false d�ner.
        }





    } 


    
    
    
    
    
    
    
    }


