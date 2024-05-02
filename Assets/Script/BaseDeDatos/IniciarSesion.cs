using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Respuesta;

public class IniciarSesion : MonoBehaviour
{
    public UsuarioDB usuario;

    public Servidor servidor;
    public TMP_InputField inpEmail;
    public TMP_InputField inpPass;
    public TMP_InputField inpEmailNP;
    public TMP_InputField inpUserNameNP;
    public TMP_InputField inpNuevoPassNp;
    public TMP_Text mensajeBienvenido;
    public TMP_Text mensajeError;
    public GameObject imgLoading;
    public GameObject imgBienvenido;
    public GameObject imgError;
    //  [SerializeField] private Persistencia datosUsuario;

    private void Awake()
    {
        string email = PlayerPrefs.GetString("Email","");
        string userName = PlayerPrefs.GetString ("UserName","");

        if (email != "" & userName !="")
        {
//            Debug.Log("Entre al if");
            SceneManager.LoadScene("Menú");
        }
    }

    public void LogIn()
    {
        if (inpEmail.text != "" & inpPass.text != "")
        {
            StartCoroutine(LogInUser());
        }
        else
        {
            imgError.SetActive(true);
            mensajeError.text = "Tienes que llenar todos los datos para iniciar sesion";
        }
        
    }
    IEnumerator LogInUser()
    {

        imgLoading.SetActive(true);
        string[] datos = new string[2];
        datos[0] = inpEmail.text;
        datos[1] = inpPass.text;

        StartCoroutine(servidor.ConsumirServicio("logIn", datos));
        yield return new WaitForSeconds(1.0f);
        yield return new WaitUntil(() => !servidor.ocupado);
        imgLoading.SetActive(false);
        if (servidor.resp.codigo == 202)
        {
            usuario = JsonUtility.FromJson<UsuarioDB>(servidor.resp.respuesta);

            mensajeBienvenido.text =" \t"+ usuario.user_name + "\n Has iniciado sesion, podemos comenzar";

            imgBienvenido.SetActive(true);
            PlayerPrefs.SetString("Email",usuario.email);
            PlayerPrefs.SetString("UserName",usuario.user_name);
            // Debug.Log("Sesion iniciada correctamente");
            //  datosUsuario.AsignarDatos(servidor.resp.respuesta, "jajaja");
            //ControladorDatos.Instance.LlenarDatos(servidor.resp.respuesta, datos[0]);
        }
        else
        {
            mensajeError.text = servidor.resp.respuesta;
            imgError.SetActive(true);
           // Debug.Log("Fallamos");
        }
    }

    public void Limpiar()
    {
        inpEmailNP.text = "";
        inpUserNameNP.text = "";
        inpNuevoPassNp.text = "";
        inpEmail.text = "";
        inpPass.text = "";
        imgError.SetActive(false);
    }
    public void SalirdeApp()
    {
        Debug.Log("Cerramos la aplicacion...");
        Application.Quit();
    }
}
