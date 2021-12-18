using UnityEngine;
[CreateAssetMenu]
public class moneySO: ScriptableObject
{
    public int moneyVal=0;

    public void addMoney(int amount)
    {
        moneyVal = moneyVal + amount;
    }
    public void subMoney(int amount)
    {
        if (moneyVal>=amount)
        {
            moneyVal = moneyVal - amount;
        }
    }

    public void levelEnd(int score)
    {
        moneyVal = moneyVal + ((score / 3) * 10);
    }
}
