// ITEM.CS

using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    [Header("Info")]
    public string itemName;
    public float itemValue;

    [Header("Sprites")]
    public Sprite itemSprite;      
    public Sprite currencySprite;  

    [Header("UI")]
    public Image itemImage;      
    public Image currencyImage;  

    public TextMeshProUGUI nameDisplay;
    public TextMeshProUGUI priceDisplay;

    [Header("Optional UI")]
    public GameObject priceObject;
    public GameObject currencyObject;

    [Header("Types")]
    public bool needPokeBolas;
    public bool isSkin;
    public bool isDinero;
    public bool givesPokeMasters;

    public float cantidad = 1f;

    public bool isOferta = false;

    void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        if (nameDisplay != null)
        {
            nameDisplay.text = itemName;
        }

        if (priceDisplay != null)
        {
            priceDisplay.text = itemValue.ToString();
        }

        if (itemImage != null)
        {
            itemImage.sprite = itemSprite;
        }

        if (currencyImage != null)
        {
            currencyImage.sprite = currencySprite;
        }
    }

    public void HideShopUI()
    {
        if (priceObject != null)
            priceObject.SetActive(false);

        if (currencyObject != null)
            currencyObject.SetActive(false);
    }
}