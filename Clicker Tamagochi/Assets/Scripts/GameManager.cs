using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] Button clickButton;
    [SerializeField] Button upgradeButton;
    [SerializeField] TMP_Text coinsText;

    int coins = 0;
    int coinsPerClick = 1;

    int upgradePrice = 20;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinsText.text = "Coins = " + coins;
        clickButton.onClick.AddListener(OnClickButton);
        upgradeButton.onClick.AddListener(OnUpgradeButton);
    }

    void OnClickButton()
    {
        coins += coinsPerClick;
        coinsText.text = "Coins = " + coins;

    }

    void OnUpgradeButton()
    {
        if (coins < upgradePrice) return;

        coins -= upgradePrice;
        coinsPerClick++;
        coinsText.text = "Coins = " + coins;
        upgradePrice = (int)(upgradePrice * 1.5f);
    }



   
}
