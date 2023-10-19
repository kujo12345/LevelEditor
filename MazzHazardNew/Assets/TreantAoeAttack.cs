using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreantAoeAttack : MonoBehaviour
{
    public LayerMask enemy;
    public float range;
    public string targetTag = "Hero";
    public float damageInterval = 1.5f;
    public float damageAmount = 10f;

    private float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= damageInterval)
        {
            timer = 0f;
            DealDamageToHeroesInRange();
        }
    }

    private void DealDamageToHeroesInRange()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, range);

        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag(targetTag))
            {
                // Implement your health reduction logic here
                var heroHealth = collider.GetComponent<IHealthSystem>();
                if (heroHealth != null)
                {
                    heroHealth.PoisonDamage(damageAmount);
                }
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }

}
