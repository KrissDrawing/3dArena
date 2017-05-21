using UnityEngine;
using System.Collections;

public class BulletShootTriggerable : MonoBehaviour {

    [HideInInspector] public AbilityGunController abilityGunController;
    [HideInInspector] public float durationTime;
    [HideInInspector] public float bulletRecoilDegree;

    public void Launch()
    {

        GetComponent<AbilityGunController>().durationTime = durationTime;
        

    }
}
