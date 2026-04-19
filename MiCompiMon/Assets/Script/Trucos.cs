using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;
public class Trucos : MonoBehaviour
{
    public static Trucos Instance;
    public InputSystem_Actions inputActions;

    public TextMeshProUGUI textPokeBola;
    public TextMeshProUGUI textPokeMaster;

    public float pokeBolas;
    public float pokeMasters;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject); // Destruir duplicado
            return;
        }

        Instance = this;
    }

    void Start()
    {
        inputActions = new InputSystem_Actions();
        inputActions.Player.Enable();

        textPokeBola.text = pokeBolas.ToString();
        textPokeMaster.text = pokeMasters.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        //Añade PokeBolas
        if (inputActions.Player.Jump.WasPressedThisFrame())
        {
            SumarPokeBolas(1000);
        }
        //Añade PokeMasters
        if (inputActions.Player.Sprint.WasPressedThisFrame())
        {
            pokeMasters += 100;
            textPokeMaster.text = pokeMasters.ToString();
        }
        //Quita Pokebolas
        if (inputActions.Player.Crouch.WasPressedThisFrame())
        {
            RestarPokeBolas(1000);
        }
        //Quita PokeMasters
        if (inputActions.Player.Interact.WasPressedThisFrame())
        {
            RestarPokeMasters(100);
        }
    }

    public void RestarPokeBolas(float cantidad)
    {
        pokeBolas -=cantidad;
        textPokeBola.text = pokeBolas.ToString();
    }
    public void RestarPokeMasters(float cantidad)
    {
        pokeMasters -=cantidad;
        textPokeMaster.text = pokeMasters.ToString();
    }

    public void SumarPokeBolas(float cantidad)
    {
        pokeBolas += cantidad;
        textPokeBola.text = pokeBolas.ToString();
    }
}
