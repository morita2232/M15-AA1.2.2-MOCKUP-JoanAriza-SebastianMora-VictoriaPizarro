using UnityEngine;

public class Botones : MonoBehaviour
{

    public GameObject normalShopPanel;
    public GameObject specialShopPanel;
    public GameObject battlePassPanel;

    public void NormalShop()
    {

        normalShopPanel.SetActive(true);
        specialShopPanel.SetActive(false);
        battlePassPanel.SetActive(false);

    }


    public void SpecialShop()
    {
        normalShopPanel.SetActive(false);
        specialShopPanel.SetActive(true);
        battlePassPanel.SetActive(false);
    }

    public void BattlePass()
    {
        normalShopPanel.SetActive(false);
        specialShopPanel.SetActive(false);
        battlePassPanel.SetActive(true);
    }

}
