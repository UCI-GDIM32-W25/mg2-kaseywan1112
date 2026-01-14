using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
    
{
    [SerializeField] public float jumpForce = 10f;
    private bool isGrounded = true;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded )
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
            isGrounded = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
          isGrounded = true;
    }
}
