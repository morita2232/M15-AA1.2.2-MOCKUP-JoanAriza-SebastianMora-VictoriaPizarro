using UnityEngine;

public class Shop : MonoBehaviour
{
    public static Shop Instance;

    [Header("UI")]
    public Transform content;

    [Header("Prefab")]
    public GameObject itemPrefab;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowcaseItem(Item purchasedItem)
    {
        GameObject newItem = Instantiate(itemPrefab, content);

        Item itemScript = newItem.GetComponent<Item>();

        itemScript.itemName = purchasedItem.itemName;
        itemScript.itemValue = purchasedItem.itemValue;

        itemScript.itemSprite = purchasedItem.itemSprite;
        itemScript.currencySprite = purchasedItem.currencySprite;

        itemScript.needPokeBolas = purchasedItem.needPokeBolas;
        itemScript.isSkin = purchasedItem.isSkin;
        itemScript.isDinero = purchasedItem.isDinero;
        itemScript.cantidad = purchasedItem.cantidad;
        itemScript.isOferta = purchasedItem.isOferta;

        itemScript.HideShopUI();
        itemScript.UpdateUI();
    }
}