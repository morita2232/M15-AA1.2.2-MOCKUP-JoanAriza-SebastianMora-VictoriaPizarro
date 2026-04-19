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
}
