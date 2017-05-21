using UnityEngine;
using System.Collections;


[CreateAssetMenu (menuName = "Ablilities/ProjectileAblility")]
public class ProjectableAblilty : Ability {

    public float projectableForce = 500f;
    public Rigidbody projectile;

    private ProjectableShootTriggerable launcher;

    public override void Initialize(GameObject obj)
    {
        launcher = obj.GetComponent<ProjectableShootTriggerable>();
        launcher.projectileForce = projectableForce;
        launcher.projectile = projectile;
    }

    public override void TriggerAbility()
    {
        launcher.Launch();

    }
}
