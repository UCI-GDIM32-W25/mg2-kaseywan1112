using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

public class CoinSpawn : MonoBehaviour
{
  [SerializeField] private GameObject coinPrefab;
    private double timer = 0f;
   
    void Start()
    {
        
    }



    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= Random.Range(0.3f, 5))
        {
            Instantiate(coinPrefab, new Vector2(Random.Range(10f,12f), Random.Range(0,4)), Quaternion.identity);
            timer = 0f;
        }

    }
}
