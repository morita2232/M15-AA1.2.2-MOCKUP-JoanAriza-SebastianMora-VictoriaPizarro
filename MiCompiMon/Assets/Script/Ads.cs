using UnityEngine;
using UnityEngine.UI;
public class Ads : MonoBehaviour
{
    public GameObject anuncio;
    public Button closeAd;
    public Image button;
    bool anuncioPlaying;
    float time = 10f;
    float duracionAnuncio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (anuncioPlaying)
        {
            time -= Time.deltaTime;
            if(time <= 0)
            {
                closeAd.interactable = true;
                button.color = Color.white;
                anuncioPlaying = false;
            }
        }
    }

    public void PlayAnuncio()
    {
        anuncioPlaying = true;
        anuncio.SetActive(true);
        closeAd.interactable = false;
        button.color = Color.gray;
        int numeroAleatorio = Random.Range(10, 20);
        duracionAnuncio = numeroAleatorio;
        time = duracionAnuncio;
    }

    public void CerrarAnuncio()
    {
        anuncio.SetActive(false);
        Trucos.Instance.SumarPokeBolas(300);
    }
}
