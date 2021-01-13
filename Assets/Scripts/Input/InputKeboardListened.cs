using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputKeboardListened : MonoBehaviour,Inpteable
{
    public void GetDireccion(Vector3 direccion)
    {
        InputProviver.TriggerDirection(direccion);
    }

    public void ShootPressed()
    {
        InputProviver.TriggerOnHasShoot();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Shoot"))
        {
            ShootPressed();
        }
        GetDireccion ( new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")));
    }


}
