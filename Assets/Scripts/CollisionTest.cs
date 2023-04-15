using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour


{
[SerializeField] Transform explosionPrefab;    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        /* if(collision.gameObject.tag == "enemy")
        {
            Destroy(collision.gameObject);
        }
        */
        ContactPoint contact = collision.contacts[0];
        Quaternion rotation = Quaternion.FromToRotation(Vector3.up,contact.normal);
        Vector3 position = contact.point;
        if (collision.gameObject.tag == "Coin")
        {
            Instantiate(explosionPrefab, position, rotation);
        }
        Debug.Log("Entrando en conlision con: "+ collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("Manteniendo colision con: "+ collision.gameObject.name);
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Saliendo de colision "+ collision.gameObject.name);
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
