using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField] Button clickButton;
    [SerializeField] Button upgradeButton;
    [SerializeField] TMP_Text coinsText;
    [SerializeField] TMP_Text upgradePriceText;

    Data data;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        data = FindObjectOfType<DataSaver>().data;
        coinsText.text = "Coins = " + data.Coins;
        upgradePriceText.text = "Upgrade price = " + data.simpleClickPrice;

        clickButton.onClick.AddListener(OnClickButton);
        upgradeButton.onClick.AddListener(OnUpgradeButton);
    }


    void OnClickButton()
    {
        data.Coins += 1 + data.simpleClick;
        coinsText.text = "Coins = " + data.Coins;

    }

    void OnUpgradeButton()
    {
        if (data.Coins < data.simpleClickPrice) return;

        data.Coins -= data.simpleClickPrice;
        data.simpleClick++;

        coinsText.text = "Coins = " + data.Coins;
        data.simpleClickPrice = (int)(data.simpleClickPrice * 1.5f);
        upgradePriceText.text = "Upgrade price = " + data.simpleClickPrice;
    }



   
}
