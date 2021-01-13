using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    [HideInInspector]
    public EnemyConfig config;
     private Mover mover;
    private Transform target;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private void Start()
    {
        mover = GetComponent<Mover>();
        if (mover != null)
        {
            mover.speed = config.moverSpeed;
        }

        if (config.sprite != null)
        {
            spriteRenderer.sprite = config.sprite;
        }
        
    }
}
