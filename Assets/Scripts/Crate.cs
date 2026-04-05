using System;
using UnityEngine;

public class Crate : MonoBehaviour
{
    GameManager GameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("Crate Clicked!");
        GameManager.money += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
