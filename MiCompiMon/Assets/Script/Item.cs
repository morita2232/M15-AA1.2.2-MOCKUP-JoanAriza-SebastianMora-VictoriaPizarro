using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{

    public string itemName;
    public float itemValue;

    public Sprite sprite;

    public Image image;

    public TextMeshProUGUI nameDisplay;
    public TextMeshProUGUI priceDisplay;

    public bool needPokeBolas;
    public bool isSkin;

    public bool isDinero;

    public float cantidad = 1f;

    public bool isOferta = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (itemName == null)
        {
            itemName = "No hay nombre";
            nameDisplay.text = itemName;
        }
        else
        {
            nameDisplay.text = itemName;
        }

        if(itemValue == 0f)
        {
            itemValue = 404f;
            priceDisplay.text = itemValue.ToString();
        }
        else
        {
            priceDisplay.text = itemValue.ToString();
        }

        image.sprite = sprite;

    }

}
