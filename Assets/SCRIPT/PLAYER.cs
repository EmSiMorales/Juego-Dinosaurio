using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLAYER : MonoBehaviour
{
    [SerializeField] float alturaSalto;
    [SerializeField] public int vida = 1;
    [SerializeField] Animator animator;
    [SerializeField] Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(Vector2.up * alturaSalto);
            animator.SetBool("Salto", true);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "enemigo")
        {
            vida -= 10;
            Destroy(collision.gameObject);
            if (vida <= 0)
            {
                Destroy(gameObject);
            }
        }
        animator.SetBool("Salto", false);
    }
}
