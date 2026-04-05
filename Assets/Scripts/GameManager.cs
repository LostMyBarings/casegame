using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI TMP;
    [SerializeField] public static int money = 100;
    void Start()
    {
    }

    void Update()
    {
        TMP.text = money.ToString("#,#");
    }
}
