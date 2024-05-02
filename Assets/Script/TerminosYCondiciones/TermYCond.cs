using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TermYCond : MonoBehaviour
{
    [SerializeField] private TMP_Text contenido;
    [SerializeField] private GameObject botonSiguiente;
    [SerializeField] private GameObject botonAceptar;
    [SerializeField] private GameObject toggle;
    public int i = 0;

    private string[] terminos =
    {
        "Términos y condiciones: \r\nPuebla Travel AR\r\nEsta aplicación es un trabajo de tesis, elaborado por Salvador Arturo Ramirez Escamilla, alumno de la Benemérita Universidad Autónoma de Puebla, identificado con la matricula 201513123.",
        "Cuenta con el Doctor Juan Manuel González Calleros, profesor investigador de la misma institución como asesor del trabajo de tesis. Esta aplicacion ha sido diseñada con el objetivo de generar e incentivar el turismo en el centro histórico de puebla y en demás sitios turísticos del estado.",
        "El objetivo de los datos que se le pedirán en el registro es para tener acceso a los beneficios de la aplicación, estos datos son: Nombre y apellidos, Correo electrónico y un nombre de usuario que el mismo creará, no se hará mal uso de sus datos, debido a que hasta el momento solo se tiene idea de registrarlos es para crear una pequeña base de datos, para posteriormente promocionar nuevas versiones o versiones mas realistas o de otros lugares, con mas beneficios o con otra finalidad." +
        "La propiedad intelectual de esta aplicación pertenece solamente a los 2 involucrados en este proyecto, quienes son el Doctor Juan Manuel González Calleros y al pasante de la Ingeniería en Ciencias de la Computación Salvador Arturo Ramirez Escamilla, ya que el doctor Juan es el dueño de la idea original siendo alimentada y modificada por Salvador Arturo.",
        "Queda prohibido su uso para fines políticos o beneficio de personas ajenas al proyecto, así como su promoción o venta sin previa autorización de los 2 creadores iniciales de la misma, siendo estos el Doctor Juan Manuel y el Pasante Salvador Arturo, así como su uso para prometer trabajos ajenos al propósito esencial del proyecto, no se permite su modificación o alguna imitación de la misma, ya que por este medio se adjudica la propiedad intelectual a Juan Manuel González Calleros y a Salvador Arturo Ramirez Escamilla desde la fecha en la que estos términos y condiciones fueron escritos, en el mes de Marzo de 2024."
    };

    private void Awake()
    {
        string tyco = PlayerPrefs.GetString("TerminosYCond");
        if ( tyco != "")
        {
            SceneManager.LoadScene("RegistrarUsuario");
        }
    }

    public void Start()
    {
        contenido.text = terminos[i];
    }
    public void Update()
    {
        contenido.text = terminos[i];
    }

    public void Actualizar()
    {
        if(i < terminos.Length - 1)
        {
            i++;
        }
        else if(i == terminos.Length - 1){
            botonSiguiente.SetActive(false);
            toggle.SetActive(true);
            PlayerPrefs.SetString("TerminosYCond","Aceptado");
           // botonAceptar.SetActive(true);
        }
    }
}
