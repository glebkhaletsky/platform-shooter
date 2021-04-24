using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float MoveSpeed;
    public float JumpSpeed;
    public float Friction;
    public bool Grounded;
    public float MaxSpeed;

    [Header("JetPack")]
    public float JetPackSpeed;
    public JetPack JetPack;
    public float MaxSpeedJet=10f;

    public Transform Capsule;
   
    private void FixedUpdate()
    {
        float speedMultiplier = 1f;

        if (!Grounded)
        {
            speedMultiplier = 0.2f;
            if (Rigidbody.velocity.x > MaxSpeed && Input.GetAxis("Horizontal") > 0)
            {
                speedMultiplier = 0f;
            }
            if (Rigidbody.velocity.x < -MaxSpeed && Input.GetAxis("Horizontal") < 0)
            {
                speedMultiplier = 0f;
            }
        }
        

        if (Grounded)
        {
            Rigidbody.AddForce(-Rigidbody.velocity.x * Friction, 0f, 0f, ForceMode.VelocityChange);
        }

        Rigidbody.AddForce(Input.GetAxis("Horizontal") * MoveSpeed * speedMultiplier, 0f, 0f, ForceMode.VelocityChange);

        if (Rigidbody.velocity.y > MaxSpeedJet && JetPack.Flight==true)
        {
            Rigidbody.velocity = new Vector3(Rigidbody.velocity.x, MaxSpeedJet, Rigidbody.velocity.z);
        }


    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift) && JetPack.Active==true)
        {
            Rigidbody.AddForce(0, JetPackSpeed, 0, ForceMode.VelocityChange);
            JetPack.Flight = true;
        }
        else
        {
            JetPack.Flight = false;
        }

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W))
        {
            if (Grounded)
            {
                Rigidbody.AddForce(0, JumpSpeed, 0, ForceMode.VelocityChange);
            }            
        }

        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.S)|| Grounded == false)
        {
            Capsule.localScale =Vector3.Lerp(Capsule.localScale, new Vector3(1f, 0.5f, 1f),Time.deltaTime*15f) ;
        }
        else
        {
            Capsule.localScale = Vector3.Lerp(Capsule.localScale, new Vector3(1f, 1f, 1f), Time.deltaTime * 15f);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        for (int i = 0; i < collision.contactCount; i++)
        {
            float angle = Vector3.Angle(collision.contacts[i].normal, Vector3.up);
            if (angle < 45f)
            {
                Grounded = true;
            }
        }              
    }

    private void OnCollisionExit(Collision collision)
    {
        Grounded = false;
    }
}
