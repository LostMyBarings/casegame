using System;
using UnityEngine;

public class Crate : MonoBehaviour
{
    GameManager GameManager;
    void Start()
    { 
    }

    void Update()
    {
    }

    private void OnMouseDown()
    {
        Debug.Log("Crate Clicked!");
        GameManager.money += GameManager.moneyPerClick;
    }
}
