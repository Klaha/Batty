using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public  class Parallax : MonoBehaviour
{
    //Referencia a cada material de cada SpriteRenderer de cada fondo.
    //Este material debe tener el Shader Unlit/Transparent 
    Material material;
    //Variable pública de la velocidad que va a tener cada fondo.
    public float velocidadFondo;
    //Vector que nos va a ayudar a modificar la dirección hacia donde se mueve el fondo.
    Vector2 vectorAuxiliar;

    void Awake()
    {
        //Asignar como primer valor de la variable material, cada material de cada Sprite Renderer de cada fondo.
        material = GetComponent<SpriteRenderer>().material;
        //Asignar como primer valor del vector, el valor de la propiedad offset de la textura del material de cada fondo.
        vectorAuxiliar = material.mainTextureOffset;
    }

    void Update()
    {
        //En cada frame, vamos a modificar el vector auxiliar en su propiedad x (horizontal),
        //agregando un valor, que depende de la velocidad que hemos asignado a cada fondo.
        vectorAuxiliar.x += velocidadFondo * 0.001f;
        //Luego ingresamos dentro del material de cada fondo y modificamos su propiedad offset en función
        //de cómo se modifica el vector auxiliar.
        //El material debe tener definido el Shader Unlit/Transparent
        //para poder modificar el offset de la textura
        material.mainTextureOffset = vectorAuxiliar;
        //Esto va a hacer que el offset vaya aumentando en su propiedad x a medida que pase el tiempo,
        //por lo tanto la imagen se moverá de derecha a izquierda.
    }


}


