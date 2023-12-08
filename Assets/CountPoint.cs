using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountPoint : MonoBehaviour
{
    public GameOver gameOver;
   public int maxHealth = 100;
    public int currentHealth;
    public HB hb;
    
    public void Start()
    {
        currentHealth = maxHealth;
        hb.SetMaxHealth(currentHealth);
        
        
    }
    private void Update()
    {
        if (currentHealth <= 0.5f)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
          
          
            if(collision.tag == "Enemy")
            {
                Destroy(collision.gameObject);
                TakeDamge(20);
              
            }
        }
       
    }
    void TakeDamge(int damge)
    {
        currentHealth -= damge;
        hb.SetHealth(currentHealth);
    }
}
