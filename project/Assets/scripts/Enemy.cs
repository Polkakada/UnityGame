using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public double attack;
    public double protection;
    public double accuracy;
    public double actionPoints;
    public double health;
    public double creteChance;
    public double evasion;

    public PointBar healthBar;
    public int maxHealth = 100;
    public int currentHealth;
    public int test;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        test = maxHealth;
        healthBar.SetMaxPoints(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth != test)
        {
            healthBar.SetPoints(currentHealth);
            test = currentHealth;
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetPoints(currentHealth);
    }
}
