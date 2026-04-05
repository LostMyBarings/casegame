using Unity.VisualScripting;
using UnityEngine;

public class Abilities : MonoBehaviour
{
    GameManager GameManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (gameObject.name == "Plus1Ability")
        {
            if (GameManager.money >= GameManager.plus1Cost)
            {
                GameManager.moneyPerClick += 1;
                GameManager.money -= GameManager.plus1Cost;
                GameManager.plus1Cost *= 1.5;
            }
        }
    }
}
