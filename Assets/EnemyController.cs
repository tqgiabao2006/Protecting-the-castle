using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyController : MonoBehaviour
{
    Animator animator;

    Rigidbody2D rb;
    Vector2 moveDir;
    [SerializeField] float _speed = 1.0f;  
    Vector2 dir = Vector2.zero;
   

    public float Health
    {
        set
        {
            print(value);
            health = value;

            if (health <= 0)
            {
                Defeated();
            }
        }
        get
        {
            return health;
        }
    }

    public float health = 1;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Defeated()
    {
        animator.SetTrigger("Defeated");
    }

    public void RemoveEnemy()
    {
        Destroy(gameObject);
    }
    private void Update()
    {
        Vector3 direction = new Vector3(dir.x - transform.position.x, dir.y - transform.position.y);
        moveDir = direction;
    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector3(moveDir.x, moveDir.y) * _speed;
    }


}
