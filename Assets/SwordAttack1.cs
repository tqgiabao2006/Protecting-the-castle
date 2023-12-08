using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack1 : MonoBehaviour
{
    Vector2 rightAttackOffset;
    public Collider2D swordCollider;
   
    public void Start()
    {
        rightAttackOffset = transform.position;
        
    }
    public void AttackRight()
    {
    
        swordCollider.enabled = true;
        transform.localPosition = rightAttackOffset;  
    }
    public void AttackLeft()
    {
        
        swordCollider.enabled = true;
        transform.localPosition = new Vector3(rightAttackOffset.x * -1, rightAttackOffset.y);
    }
    public void StopAttack()
    {
        swordCollider.enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            killCount.instance.killcount++;
            killCount.instance.killCounter();
            Destroy(collision.gameObject);
            
            
        }
    }
}
