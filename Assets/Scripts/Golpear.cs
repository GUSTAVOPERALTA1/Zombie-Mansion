using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Golpear : MonoBehaviour
{
    public int cantidad = 5;

   void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Player")) 
        {
            Debug.Log("Daño de Zombie");
            other.GetComponent<VidaDaño>().RestarVida(cantidad);
        }
    }
}
