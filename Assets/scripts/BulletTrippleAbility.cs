using UnityEngine;
using System.Collections;


[CreateAssetMenu(menuName = "Ablilities/BulletTrippleAbility")]
public class BulletTrippleAbility : Ability {

	public float bulletRecoilDegree;
    public float durationTime;
    public AbilityGunController abilityGunController;

    private BulletShootTriggerable launcher;

    public override void Initialize(GameObject obj)
    {
        launcher = obj.GetComponent<BulletShootTriggerable>();
        launcher.abilityGunController = abilityGunController;
        launcher.durationTime = durationTime;
        launcher.bulletRecoilDegree = bulletRecoilDegree;
    }

    public override void TriggerAbility()
    {
        launcher.Launch();

    }
}
