using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    [SerializeField] private TMP_InputField nameInput;
    [SerializeField] private Slider volumeSlider;
    [SerializeField] private TMP_Dropdown resolution;

    private void Start()
    {
        Values();

    }
    public void Values()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volumeSlider");
        nameInput.text = PlayerPrefs.GetString("inputName");
        resolution.value = PlayerPrefs.GetInt("resolution");

    }
    public void SetVolumen()
    {
        PlayerPrefs.SetFloat("volumeSlider", volumeSlider.value);
        // Guardar los datos del volumen.
    }


    public void SetName()
    {
        PlayerPrefs.SetString("inputName", nameInput.text);
        // Guardar los datos del nombre.
    }


    public void SetResolution()
    {
        PlayerPrefs.SetInt("resolution", resolution.value);
        // Guardar los datos de la resolucion.
    }

    public void ResetDefault()
    {
        PlayerPrefs.DeleteAll();
        Values();
        // Borrar todos los datos existentes.
    }
}

