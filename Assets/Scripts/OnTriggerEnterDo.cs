﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class OnTriggerEnterDo : MonoBehaviour
{
    [SerializeField] private UnityEvent accion;

    private GameObject collisionee;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        collisionee = collision.gameObject;
        accion.Invoke();
    }

    public void DestroyCollisionee()
    {
        if (collisionee != null)
        {
            Destroy(collisionee);
        }
    }
}
