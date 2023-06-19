using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehavior : MonoBehaviour
{
    public Transform paddle;
    bool gameStarted = false; //Variable bool para confirmar si el juego inicio.
    float posDif = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameStarted)
        {

             posDif = paddle.position.x - transform.position.x; //Restamos la posicion del Paddle con el transform del mismo objeto para obtener la diferencia.
            transform.position = new Vector3(paddle.position.x - posDif, paddle.position.y, paddle.position.z); //Luego, asignamos el nuevo vector3 a objeto para su nueva posicion.

            if (Input.GetMouseButtonDown(0))
            { //Al momento de dar click en nuestra pantalla el juego inicia.
                gameStarted = true;
            }
        }

    }

}

