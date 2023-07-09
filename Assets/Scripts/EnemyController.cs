using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{

    public Sprite idle, shoot, shooting;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {

            this.gameObject.GetComponent<SpriteRenderer>().sprite = shooting;
        }

        if (Input.GetKey(KeyCode.R))
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = idle;
            Invoke("collectableWeapon", 25);
        }

    }

    public void collectableWeapon()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = idle;
    }
}