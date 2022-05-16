using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAICombat : MonoBehaviour
{
    public float minDamage = 5;
    public float maxDamage = 10;
    public HealthBarScript healthBarScript;


    private void Awake()
    {
        healthBarScript = GameObject.Find("PlayerHealthBar").GetComponent<HealthBarScript>();
    }
        
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("HITTT");
            float damage = Random.Range(minDamage, maxDamage);
            float health = healthBarScript.GetHealth();
            float newHealth = health -= damage;
            healthBarScript.SetHealth(newHealth);
            Debug.Log("Player was hit, Hp left: " + newHealth);
           
        }
    }
   
}
