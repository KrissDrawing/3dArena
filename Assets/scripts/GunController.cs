using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {
     
    public bool isFiring;

    public BulletController bullet;
    public float bulletSpeed;

    public float bulletRecoilDegree;

    public float timeBetweenShots;
    [HideInInspector] public float shotCounter;
    

    public Transform firePoint;
    public Transform throwPoint;

    // Use this for initialization
    void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {


        if (isFiring)
        {

            shotCounter -= Time.deltaTime;
            if(shotCounter <=0)
            {
                float randPos = Random.Range(-bulletRecoilDegree, bulletRecoilDegree);
                Quaternion randomQuaternion = Quaternion.Euler(randPos, randPos, randPos);
                shotCounter = timeBetweenShots;
                BulletController newBullet = Instantiate(bullet, firePoint.position , firePoint.rotation * randomQuaternion) as BulletController;
                newBullet.speed = bulletSpeed;
            }
        } else
        {
            shotCounter = 0;
        }

    }
}
