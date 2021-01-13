using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector3 direccion;
    public float speed;

    private void Update()
    {
        transform.Translate(direccion * speed * Time.deltaTime);
    }

    public void Movimiento(Vector3 validarMovimiento)
    {
        transform.Translate(validarMovimiento);

    }
}
