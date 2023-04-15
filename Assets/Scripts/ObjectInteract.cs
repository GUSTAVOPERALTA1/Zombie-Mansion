using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteract : MonoBehaviour
{
    public float velocity = 1f;
    public Inventary inventary;
    // Start is called before the first frame update
    void Start()
    {   
        inventary = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventary>();
    }
    void Update()
    {
        transform.Rotate(0f, velocity * Time.deltaTime, 0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player"){
            inventary.Amount = inventary.Amount +1;
            inventary.coins.text = ("Coins: " + inventary.Amount+"/7");
            
            Destroy(gameObject);
        }
    }

}
