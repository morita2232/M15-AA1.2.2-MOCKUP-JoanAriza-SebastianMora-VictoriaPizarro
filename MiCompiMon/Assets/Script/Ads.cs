using UnityEngine;
using UnityEngine.UI;

public class Ads : MonoBehaviour
{
    public GameObject anuncio;
    public Button closeAd;
    public Image button;
    public Slider slider;

    bool anuncioPlaying;
    float time = 10f;
    float duracionAnuncio;

    void Update()
    {
        if (anuncioPlaying)
        {
            time -= Time.deltaTime;
            slider.value = time;

            if (time <= 0)
            {
                closeAd.interactable = true;
                button.color = Color.white;
                anuncioPlaying = false;
                slider.value = 0;
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

        slider.maxValue = duracionAnuncio;
        slider.value = duracionAnuncio;
    }

    public void CerrarAnuncio()
    {
        anuncio.SetActive(false);
        Trucos.Instance.SumarPokeBolas(300);
    }
}