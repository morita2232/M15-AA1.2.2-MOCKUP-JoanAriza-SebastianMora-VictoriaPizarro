using UnityEngine;
using UnityEngine.UI;

public class Comprar : MonoBehaviour
{
    public Item item;    

    public Button button;

    public Image image;

    public void ComprarCosa()
    {
        if (item.needPokeBolas)
        {
            if (Trucos.Instance.pokeBolas >= item.itemValue)
            {
                Trucos.Instance.RestarPokeBolas(item.itemValue);

                Shop.Instance.ShowcaseItem(item);

                IsSkin();
                IsOferta();
            }
        }
        else
        {
            if (Trucos.Instance.pokeMasters >= item.itemValue)
            {
                Trucos.Instance.RestarPokeMasters(item.itemValue);

                Shop.Instance.ShowcaseItem(item);

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

            if (item.givesPokeMasters)
            {
                Trucos.Instance.RestarPokeBolas(item.itemValue) ;
                Trucos.Instance.SumarPokeMasters(item.cantidad);                
            }
            
            if (Trucos.Instance.dinero >= item.itemValue)
            {
                Trucos.Instance.dinero -= item.itemValue;                

                Trucos.Instance.SumarPokeBolas(item.cantidad);
                
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