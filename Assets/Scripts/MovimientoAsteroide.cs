using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoAsteroide : MonoBehaviour
{
    // Start is called before the first frame update
    public Mover mover;

    private void Update()
    {
        Vector3 dezplazamiento = new Vector3(UnityEngine.Random.RandomRange(-1f, 1f), UnityEngine.Random.RandomRange(-1f, 1f), transform.position.z);
        mover.Movimiento(dezplazamiento);

    }
}
