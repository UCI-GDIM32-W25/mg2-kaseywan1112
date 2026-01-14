using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float speed = 5f;
    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }
}
