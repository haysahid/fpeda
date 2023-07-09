using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public Sprite idle, shoot, shooting;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = shooting;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("epcom_shot");
            animator.SetBool("epcom_hit", true);

            //this.gameObject.GetComponent<SpriteRenderer>().sprite = idle;
        }

    }
}