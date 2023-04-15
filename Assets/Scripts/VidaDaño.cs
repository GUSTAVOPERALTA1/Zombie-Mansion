using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VidaDaño : MonoBehaviour
{
    private Animator anim;
    public int vida = 100;
    public Image barraDeVida;
    private Rigidbody rb;
    private CharacterController cc;


    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        cc = GetComponent<CharacterController>();
    }
    
    public void LoadScene(string sceneName){
        SceneManager.LoadScene(sceneName);
    }
   public void RestarVida(int cantidad)
   {
        vida -= cantidad;
        anim.Play("Damage");
        if (vida <= 0)
        {
            Die();
        }
        barraDeVida.fillAmount = (float)vida / 100f;
   }

   private void Die()
   {
        LoadScene("GameOverGolpe");
   }
}
