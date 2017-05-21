using UnityEngine;
using System.Collections;

public class AbilityGunController : GunController {

    public bool isActive;

    public float durationTime;

    public GunController theGun;

    // Use this for initialization
    void Start () {
        theGun = GetComponent<GunController>();
	}
	
	// Update is called once per frame
	void Update () {

        durationTime -= Time.deltaTime;

        if (durationTime > 0)
        {

            if (GetComponent<GunController>().isFiring )
            {
                theGun.shotCounter -= Time.deltaTime;
                if (theGun.shotCounter <= 0)
               {
                    float randPos = Random.Range(-bulletRecoilDegree, bulletRecoilDegree);
                    Quaternion randomQuaternion = Quaternion.Euler(randPos, randPos, randPos);
                    BulletController newBullet = Instantiate(bullet, firePoint.position, (firePoint.rotation * Quaternion.Euler(new Vector3(0, 5, 0))) * randomQuaternion) as BulletController;
                    BulletController newBullet1 = Instantiate(bullet, firePoint.position, (firePoint.rotation * Quaternion.Euler(new Vector3(0, -5, 0))) * randomQuaternion) as BulletController;
                    newBullet.speed = theGun.bulletSpeed + Random.Range((float)-(theGun.bulletSpeed*0.1), (float)(theGun.bulletSpeed * 0.1));
                    newBullet1.speed = theGun.bulletSpeed + Random.Range((float)-(theGun.bulletSpeed * 0.1), (float)(theGun.bulletSpeed * 0.1)); ;
                }
            }
            else
            {
                theGun.shotCounter = 0;
            }
        }

    }
}
