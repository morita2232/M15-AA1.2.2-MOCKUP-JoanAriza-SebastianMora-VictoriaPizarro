using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using System.Collections.Generic;

public class Trucos : MonoBehaviour
{
    public static Trucos Instance;
    public InputSystem_Actions inputActions;

    public List<TextMeshProUGUI> textPokeBola;
    public List<TextMeshProUGUI> textPokeMaster;

    public float pokeBolas;
    public float pokeMasters;

    public float dinero = 5000f;
    bool hasPass = false;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        Instance = this;
    }

    void Start()
    {
        inputActions = new InputSystem_Actions();
        inputActions.Player.Enable();

        UpdatePokeBolasUI();
        UpdatePokeMastersUI();
    }

    void Update()
    {
        if (inputActions.Player.Jump.WasPressedThisFrame())
        {
            SumarPokeBolas(1000);
        }

        if (inputActions.Player.Sprint.WasPressedThisFrame())
        {
            pokeMasters += 100;
            UpdatePokeMastersUI();
        }

        if (inputActions.Player.Crouch.WasPressedThisFrame())
        {
            RestarPokeBolas(1000);
        }

        if (inputActions.Player.Interact.WasPressedThisFrame())
        {
            RestarPokeMasters(100);
        }
    }

    public void RestarPokeBolas(float cantidad)
    {
        pokeBolas -= cantidad;
        UpdatePokeBolasUI();
    }

    public void RestarPokeMasters(float cantidad)
    {
        pokeMasters -= cantidad;
        UpdatePokeMastersUI();
    }

    public void SumarPokeBolas(float cantidad)
    {
        pokeBolas += cantidad;
        UpdatePokeBolasUI();
    }

    void UpdatePokeBolasUI()
    {
        foreach (TextMeshProUGUI text in textPokeBola)
        {
            text.text = pokeBolas.ToString();
        }
    }

    void UpdatePokeMastersUI()
    {
        foreach (TextMeshProUGUI text in textPokeMaster)
        {
            text.text = pokeMasters.ToString();
        }
    }

    public void RestarDineros(float cantidad, float conseguido)
    {
        dinero -= cantidad;
        SumarPokeBolas(conseguido);
        Debug.Log(dinero);
    }

    public void ComprarPase(float cantidad)
    {
        if(dinero >= cantidad && !hasPass)
        {
            dinero -= cantidad;
            hasPass = true;
        }
    }
}