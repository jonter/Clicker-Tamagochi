using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
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
        upgradePriceText.text = "Upgrade price = " + data.UpgradePrice;
        clickButton.onClick.AddListener(OnClickButton);
        upgradeButton.onClick.AddListener(OnUpgradeButton);
       
    }

    public void DisplayTexts()
    {
        data = FindObjectOfType<DataSaver>().data;
        coinsText.text = "Coins = " + data.Coins;
        upgradePriceText.text = "Upgrade price = " + data.UpgradePrice;
    }

    void OnClickButton()
    {
        data.Coins += data.CoinsPerClick;
        coinsText.text = "Coins = " + data.Coins;

    }

    void OnUpgradeButton()
    {
        if (data.Coins < data.UpgradePrice) return;

        data.Coins -= data.UpgradePrice;
        data.CoinsPerClick++;
        coinsText.text = "Coins = " + data.Coins;
        data.UpgradePrice = (int)(data.UpgradePrice * 1.5f);
        upgradePriceText.text = "Upgrade price = " + data.UpgradePrice;
    }



   
}
