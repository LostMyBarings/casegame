using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;

public class Abilities : MonoBehaviour , IPointerEnterHandler , IPointerExitHandler , IPointerClickHandler
{
    private Vector2 velocity = Vector2.zero;
    private float smoothTime = 0.3f;
    GameManager GameManager;
    public GameObject plus1CostDropdown;
    public Vector2 targetPosition = new Vector2(1278, 686);
    void Start()
    {
    }

    void Update()
    {

    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        plus1CostDropdown.transform.position = Vector2.SmoothDamp(plus1CostDropdown.transform.position, targetPosition, ref velocity, smoothTime);
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
