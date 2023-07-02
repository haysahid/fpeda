using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Shooting
        if (Input.GetKey(KeyCode.R))
        {
            Shoot();
        }
    }

    // Shooting
    private void Shoot()
    {
        animator.SetTrigger("shoot");
        animator.SetBool("shooting", true);
    }
}
