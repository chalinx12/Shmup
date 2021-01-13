using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover_Escenario : MonoBehaviour
{

    public float velocidadDesplazamiento = 0.5f;
    [SerializeField] private MeshRenderer mesh;

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(0,Time.time * velocidadDesplazamiento);
        mesh.material.mainTextureOffset = offset;
        
    }


}
