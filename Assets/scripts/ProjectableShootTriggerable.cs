using UnityEngine;
using System.Collections;

public class ProjectableShootTriggerable : MonoBehaviour {

    [HideInInspector] public Rigidbody projectile;
    public Transform granadeSpawn;
    [HideInInspector] public float projectileForce = 250f;

    public void Launch()
    {
        Rigidbody clonedGranade = Instantiate(projectile, granadeSpawn.position, granadeSpawn.rotation) as Rigidbody;
        clonedGranade.AddRelativeTorque(new Vector3(1, 0, 0));
        clonedGranade.AddForce((granadeSpawn.transform.forward + granadeSpawn.transform.up * 0.5f) * projectileForce);
        
    }
}
