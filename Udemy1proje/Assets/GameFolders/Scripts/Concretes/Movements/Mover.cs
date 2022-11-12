using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


        //proje adý    //class adý
namespace Udemy1proje.Movements //newspace,classlarýmýzý birbirinden ayirma yöntemidir.

    //classlarý neden birbirinden ayiririz? her classýn bir görevi olacak örneðin mover roketi haraket ettirmek
    //controlun görevi bunlarý yönetmek. defaultinput ýnputlarý kontrol etmek.
{
    //hareketi saðlayacak olan classým.
    public class Mover //normal bir classým olucak.
    {

        Rigidbody _rigidbody;

        
        public Mover(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;

        }
         
        public void FixedTick() //tick updatelerde kullanýlýr,fixedtickde fixedupdate içindir.
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * 35676f); //addrelativeforce,burda þunu yapýyor bu bizim pozisyonumuza göre force yani kuvvet veriyor
        }



    }
}

