using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject Maps, Pause, Inventory;

    public int counter;

    void Start()
    {

    }

    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Escape)) { pauseGame(counter == 0 ? true : false); }
        if (Input.GetKeyDown(KeyCode.M)) { showMaps(counter == 0 ? true : false); }
        if (Input.GetKeyDown(KeyCode.I)) { openInventory(counter == 0 ? true : false); }

        if (counter > 1) { counter = 0; };
    }

    public void showMaps(bool key)
    {
        Maps.gameObject.SetActive(key);
        counter++;

    }

    public void pauseGame(bool key)
    {
        Pause.gameObject.SetActive(key);
        counter++;
    }

    public void openInventory(bool key)
    {
        Inventory.gameObject.SetActive(key);
        counter++;
    }
}