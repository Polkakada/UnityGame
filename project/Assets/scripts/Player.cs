using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public double attack;
    public double protection;
    public double accuracy;
    public int maxActionPoints=100;
    public int currentActionPoints;
    public int maxHealth = 100;
    public int currentHealth;

    
    public double baseDamageResistance;
    public double creteChance;
    public double evasion;
    public PointBar healthBar;
    public PointBar actionPointsBar;
    public int test;
    // Start is called before the first frame update
    void stab(int enemyNumber)
    {
        

    }
    void Start()
    {
        GameObject.Find("HeroAttack").GetComponent<Text>().text = "1";
        currentHealth = maxHealth;
        healthBar.SetMaxPoints(maxHealth);

        currentActionPoints = maxActionPoints;
        actionPointsBar.SetMaxPoints(maxActionPoints);
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject.Find("Text").GetComponent<Text>().text = "12";
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(20);
        }

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
