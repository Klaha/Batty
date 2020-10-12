﻿using UnityEngine;
using UnityEngine.UI;

public class Batty : MonoBehaviour
{
    public Rigidbody2D rb2d;
    int fuerza;

    int contador;
    public Text cajaPuntuacion;

    // Start is called before the first frame update
    void Start()
    {
        fuerza = 5;
        contador = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // (0,1) * fuerza.
            rb2d.velocity = Vector2.up * fuerza;
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Obstaculo")){
            Destroy(gameObject);
        } else
        {
            SumarPuntos();
        }
    }

    void SumarPuntos()
    {
        contador++;
        cajaPuntuacion.text = contador.ToString();
    }
}
