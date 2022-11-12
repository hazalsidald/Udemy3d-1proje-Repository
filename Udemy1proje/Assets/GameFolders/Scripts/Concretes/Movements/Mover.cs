using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


        //proje ad�    //class ad�
namespace Udemy1proje.Movements //newspace,classlar�m�z� birbirinden ayirma y�ntemidir.

    //classlar� neden birbirinden ayiririz? her class�n bir g�revi olacak �rne�in mover roketi haraket ettirmek
    //controlun g�revi bunlar� y�netmek. defaultinput �nputlar� kontrol etmek.
{
    //hareketi sa�layacak olan class�m.
    public class Mover //normal bir class�m olucak.
    {

        Rigidbody _rigidbody;

        
        public Mover(Rigidbody rigidbody)
        {
            _rigidbody = rigidbody;

        }
         
        public void FixedTick() //tick updatelerde kullan�l�r,fixedtickde fixedupdate i�indir.
        {
            _rigidbody.AddRelativeForce(Vector3.up * Time.deltaTime * 35676f); //addrelativeforce,burda �unu yap�yor bu bizim pozisyonumuza g�re force yani kuvvet veriyor
        }



    }
}

