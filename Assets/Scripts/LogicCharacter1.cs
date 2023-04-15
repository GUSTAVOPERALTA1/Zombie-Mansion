using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicCharacter1 : MonoBehaviour
{
    public float velocityMove = 5.0f;
    public float velocityRotation = 200.0f;
    private Animator anim;
    public float x,y;

    public void onTriggerEnter(Collider coll)
    {
        if(coll.CompareTag("Enemy"))
        {
            print("Golpe Enemigo");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

        transform.Rotate(0,x * Time.deltaTime * velocityRotation, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocityMove);

        anim.SetFloat("VelX",x);
        anim.SetFloat("VelY",y);

    }
}
