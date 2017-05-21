using UnityEngine;
using System.Collections;

public class EnemySpawnerController : MonoBehaviour {

    public float spawnTime;
    private float spawnCounter;

    public EnemyController enemy;
    public Transform spawnPoint;

	// Use this for initialization
	void Start () {
        spawnCounter = spawnTime;
	}
	
	// Update is called once per frame
	void Update () {
        spawnCounter -= Time.deltaTime;

        if (spawnCounter < 0)
        {
            Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
            spawnCounter = spawnTime;
        }

	}
}
