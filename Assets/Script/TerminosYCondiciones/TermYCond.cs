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
        "T�rminos y condiciones: \r\nPuebla Travel AR\r\nEsta aplicaci�n es un trabajo de tesis, elaborado por Salvador Arturo Ramirez Escamilla, alumno de la Benem�rita Universidad Aut�noma de Puebla, identificado con la matricula 201513123.",
        "Cuenta con el Doctor Juan Manuel Gonz�lez Calleros, profesor investigador de la misma instituci�n como asesor del trabajo de tesis. Esta aplicacion ha sido dise�ada con el objetivo de generar e incentivar el turismo en el centro hist�rico de puebla y en dem�s sitios tur�sticos del estado.",
        "El objetivo de los datos que se le pedir�n en el registro es para tener acceso a los beneficios de la aplicaci�n, estos datos son: Nombre y apellidos, Correo electr�nico y un nombre de usuario que el mismo crear�, no se har� mal uso de sus datos, debido a que hasta el momento solo se tiene idea de registrarlos es para crear una peque�a base de datos, para posteriormente promocionar nuevas versiones o versiones mas realistas o de otros lugares, con mas beneficios o con otra finalidad." +
        "La propiedad intelectual de esta aplicaci�n pertenece solamente a los 2 involucrados en este proyecto, quienes son el Doctor Juan Manuel Gonz�lez Calleros y al pasante de la Ingenier�a en Ciencias de la Computaci�n Salvador Arturo Ramirez Escamilla, ya que el doctor Juan es el due�o de la idea original siendo alimentada y modificada por Salvador Arturo.",
        "Queda prohibido su uso para fines pol�ticos o beneficio de personas ajenas al proyecto, as� como su promoci�n o venta sin previa autorizaci�n de los 2 creadores iniciales de la misma, siendo estos el Doctor Juan Manuel y el Pasante Salvador Arturo, as� como su uso para prometer trabajos ajenos al prop�sito esencial del proyecto, no se permite su modificaci�n o alguna imitaci�n de la misma, ya que por este medio se adjudica la propiedad intelectual a Juan Manuel Gonz�lez Calleros y a Salvador Arturo Ramirez Escamilla desde la fecha en la que estos t�rminos y condiciones fueron escritos, en el mes de Marzo de 2024."
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
