using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public bool isbool;
    public float speed = 5;
    public float gravity = -5;
    float yVelocity = 0;
    public CharacterController cc;

    public gameameger events;

    public float jumpPower = 2;

    
    void Awake()
    {
        cc = GetComponent<CharacterController>();
        events = GameObject.Find("gameameger").GetComponent<gameameger>();
    }


    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //Debug.Log(h+v);
        Vector3 dir = new Vector3(0, 0, v);
        Debug.Log(dir);
        dir = Camera.main.transform.TransformDirection(dir);

        //yVelocity = yVelocity + gravity * Time.deltaTime;
        yVelocity += gravity * Time.deltaTime;

        if (cc.isGrounded)
        {
            yVelocity = 0;
        }

        if (isbool)
        {
            if (cc.isGrounded)
            {
                yVelocity = jumpPower;
            }

            else
            {
                yVelocity = 0.5f;
            }
        }

        dir.y = yVelocity;
        cc.Move(dir * speed * Time.deltaTime);

    }



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name + "other");
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.collider.tag == "CUVE2")
        {

            Debug.Log(hit.collider.name + "hit");
            events.create();

        }

    }
}
