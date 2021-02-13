using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 3;
    public event Action<Player> onPlayerDeath;

    void FixedUpdate(){
        if(health < 1){
            UnityEngine.SceneManagement.SceneManager.LoadScene("Credits");
        }
    }

    void collidedWithEnemy(Enemy enemy)
    {
        enemy.Attack(this);
        if(health <= 0){
            if(onPlayerDeath != null){
                onPlayerDeath(this);
            }
        }
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        Enemy enemy = col.collider.gameObject.GetComponent<Enemy>();
        if(enemy){
        collidedWithEnemy(enemy);
        }
    }
}
