using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

//Oblicamos a que el objeto al que se le agregue este script, tenga que contener estos componentes
//para poder ser asignado... 
[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]
public class OptionButons : MonoBehaviour
{
    private TMP_Text preguntaTexto = null;
    private Button miButton = null;
    private Image miImage = null;
    private Color miColor = Color.black;

    public Option Option { get; set; }

    private void Awake()
    {
        miButton = GetComponent<Button>();
        miImage = GetComponent<Image>();
        preguntaTexto = transform.GetChild(0).GetComponent<TMP_Text>();

        miColor = miImage.color;

    }
    public void Constructor(Option op, Action<OptionButons> call)
    {
        preguntaTexto.text = op.text;

        miButton.onClick.RemoveAllListeners();
        miButton.enabled = true;
        miImage.color = miColor;

        Option = op;
        miButton.onClick.AddListener(delegate
        {
            call(this);
        });
    }

    public void SetColor(Color c)
    {
        miButton.enabled = false;
        miImage.color = c;
    }
}
