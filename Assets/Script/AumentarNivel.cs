using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AumentarNivel : MonoBehaviour
{
     public int aumentar = 10;

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Cultivo"){
            other.GetComponent <Riego>().AumentarNivel(aumentar);
        }
    }

    private void OnTriggerStay(Collider other) {
        if(other.tag == "Cultivo"){
            other.GetComponent <Riego>().AumentarNivel(aumentar);
        }
    }
}