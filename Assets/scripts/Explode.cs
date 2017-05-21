using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour
{

    public float explosionTime;
    public float explosionRadius;
    public int damageToGive;
    private float explosionCounter;
    private bool isExploding;

    public GameObject explosion;
    public Rigidbody granade;

    void Start()
    {
        explosionCounter = explosionTime;
        isExploding = true;
    }


    // Update is called once per frame
    void Update()
    {

        explosionCounter -= Time.deltaTime;

        if (explosionCounter <= 0)
        {
            if (isExploding)
            {
                GameObject expl = (GameObject)Instantiate(explosion, granade.position, Quaternion.identity);
                isExploding = false;
                Destroy(expl, 2);
                explode();
            }
        }
    }

    void explode()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);
        foreach (Collider collider in colliders)
        {
            if (collider.tag == "Enemy")
            {
                Damage(collider.transform);
            }
        }
    }

    void Damage(Transform enemy)
    {
        enemy.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
       // enemy.GetComponent<Rigidbody>().AddExplosionForce(5000, granade.position, 10000);
    }
}
