using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Limite
{
    public float xMinimo, xMaximo, yMinimo, yMaximo;

}


public class PlayerControl : MonoBehaviour
{
    public Mover moverComponente;
    public float velocidad;
    public Limite limite;
   

    public Transform shootOrigin;
    public GameObject shootPrefab;

    void Start()
    {
        moverComponente.speed = velocidad;
        InputProviver.OnhasShoot += OnhasShoot;
        InputProviver.OnDireccion += Ondireccion;
    }

    private void Ondireccion(Vector3 direccion)
    {
        moverComponente.direccion = direccion; 
    }
    
    private void OnhasShoot()
    {
        
        Instantiate(shootPrefab, shootOrigin.position, shootOrigin.rotation);
    }

    void Update()
    {      
        //limite de los valores x e y para el escenario
        float x = Mathf.Clamp(transform.position.x, limite.xMinimo, limite.xMaximo);
        float y = Mathf.Clamp(transform.position.y, limite.yMinimo, limite.yMaximo);
        transform.position = new Vector3(x, y);
    }

    

}
