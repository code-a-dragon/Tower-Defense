using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour
{

    public int startingMoney = 150;
    private int currentMoney = 0;
    public Text moneyText;

    private float secondsSinceLastMoneyDump;
    public float secondsPerMoneyDump = 5f;
    public int moneyPerDump = 10;

    public ErrorMessageScript errorMessageScript;
    public ActionHandlerScript actionHandlerScript;

    public GameObject standardTower;
    public GameObject standardTowerHologram;

    void Start()
    {
        changeMoney(startingMoney);
    }

    void Update()
    {
        //updates money regularly
        secondsSinceLastMoneyDump += Time.deltaTime;
        if(secondsSinceLastMoneyDump >= secondsPerMoneyDump)
        {
            secondsSinceLastMoneyDump -= secondsPerMoneyDump;
            changeMoney(moneyPerDump);
        }
    }

    public void clickPurchaseTurretButton(GameObject tower, GameObject towerHologram)
    {
        actionHandlerScript.selectTowerToPlace(tower, towerHologram);
    }

    public void changeMoney(int amount)
    {
        currentMoney += amount;
        moneyText.text = "  Cash: $" + currentMoney;
    }

    public int getMoney()
    {
        return currentMoney;
    }

    public bool checkIfMoneyGreaterOrEqual(int amount)
    {
        return currentMoney >= amount;
    }
}
