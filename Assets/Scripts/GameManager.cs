using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI moneyPerClickText;
    [SerializeField] TextMeshProUGUI plus1CostText;
    public static double money = 100;
    public static double moneyPerClick = 1;
    public static double plus1Cost = 10;

    void Start()
    {
    }

    void Update()
    {
        moneyText.text = money.ToString("#,#");
        moneyPerClickText.text = "+ " + moneyPerClick.ToString("#,#");
        plus1CostText.text = "$ " + plus1Cost.ToString("#,#");
    }
}
