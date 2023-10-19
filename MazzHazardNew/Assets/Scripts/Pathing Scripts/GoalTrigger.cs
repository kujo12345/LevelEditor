using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalTrigger : MonoBehaviour
{
    public EnemyCounter enemyCounter;
    public GameObject gameOverUi;
    public Text txt_lifeCount;
    public int maxLife;
    public int currentLife;

    private void Start() {
        currentLife = maxLife;
        txt_lifeCount.text = currentLife.ToString();    
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Debug.Log("Destroyed");
            LoseHealth();
            enemyCounter.DecreaseEnemy();
        }    
    }

    private void LoseHealth()
    {
        if(currentLife<1)//For Sanity Check only
            return;

        currentLife--;
        txt_lifeCount.text = currentLife.ToString(); 
        CheckHealth();
    }

    private void CheckHealth()
    {
        if(currentLife<1)
        {
            gameOverUi.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
