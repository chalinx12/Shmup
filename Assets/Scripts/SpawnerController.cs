using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour{

    public List<GameObject> enemyPrefabs;
    public List<EnemyConfig> enemyConfig;


    // public List<Transform> spawPoints;
    public Vector3 spawReferencePosition;
    public Quaternion spawRotation;
    public int amountToSpawn;
    public float spawCadence;
    public float initiaWaitime;
     
    private void Start()
    {
        StartCoroutine(EnemySpawnerCoroutime());
    }

    private IEnumerator EnemySpawnerCoroutime()
    {
        yield return new WaitForSeconds(initiaWaitime);
        for (int i = 0; i < amountToSpawn; i++)
        {
            Vector3 randomPosition =
                new Vector3(Random.Range(-spawReferencePosition.x, spawReferencePosition.x), spawReferencePosition.y, spawReferencePosition.z);
            SpawEnemy(randomPosition, spawRotation);
            yield return new WaitForSeconds(spawCadence);
        }
    }

    public void SpawEnemy(Vector3 enemyPosition,Quaternion rotation)
    {
        int randomIndex = Random.Range(0, enemyPrefabs.Count);
        var enemyInstance=Instantiate(enemyPrefabs[randomIndex], enemyPosition, rotation);
        var enemyController = enemyInstance.GetComponent<EnemyController>();
        if (enemyController != null)
        {
            int randomConfigIndex = Random.Range(0, enemyConfig.Count);
            enemyController.config = enemyConfig[randomConfigIndex];

        }
    }


    
}
