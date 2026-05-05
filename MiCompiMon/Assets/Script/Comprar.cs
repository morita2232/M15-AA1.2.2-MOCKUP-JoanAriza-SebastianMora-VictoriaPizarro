using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class Comprar : MonoBehaviour
{

    public Item item;
    public Button button;

    public Image image;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void ComprarCosa()
    {
        if (item.needPokeBolas)
        {
            if(Trucos.Instance.pokeBolas >= item.itemValue)
            {
                Trucos.Instance.RestarPokeBolas(item.itemValue);
                IsSkin();
                IsOferta();
            }
        }
        else
        {
            if(Trucos.Instance.pokeMasters >= item.itemValue)
            {
                Trucos.Instance.RestarPokeMasters(item.itemValue);
                IsSkin();
            }
        }
    }

    void IsSkin()
    {
        if (item.isSkin)
        {
            button.interactable = false;
            image.color = Color.gray;
        }
    }

    public void ComprarPokeCosas()
    {
        if (item.isDinero)
        {
            if(Trucos.Instance.dinero >= item.itemValue)
            {
                Trucos.Instance.RestarDineros(item.itemValue, item.cantidad);
            }
        }
    }
    void IsOferta()
    {
        if (item.isOferta)
        {
            button.interactable = false;
            image.color = Color.gray;
        }
    }
}
