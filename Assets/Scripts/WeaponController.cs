using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public Sprite none, deathray;

    public void changeDeathray()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = deathray;
    }

    public void changeNone()
    {
        this.gameObject.GetComponent<SpriteRenderer>().sprite = none;
    }
}