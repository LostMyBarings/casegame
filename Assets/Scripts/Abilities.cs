using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class Abilities : MonoBehaviour , IPointerEnterHandler , IPointerExitHandler , IPointerClickHandler
{
    GameManager GameManager;
    public GameObject plus1CostDropdown;
    void Start()
    {
        
    }

    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        plus1CostDropdown.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        plus1CostDropdown.SetActive(false);
    }

    public void OnPointerClick(PointerEventData eventData)
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
