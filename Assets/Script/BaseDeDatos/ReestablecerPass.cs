using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Respuesta;
using UnityEngine.SceneManagement;

public class ReestablecerPass : MonoBehaviour
{
    public UsuarioDB usuario;

    public Servidor servidor;
    public TMP_InputField inpEmail;
    public TMP_InputField inpUserName;
    public TMP_InputField inpNuevoPass;
    public TMP_Text mensajeBienvenido;
    public TMP_Text mensajeError;
    public GameObject imgLoading;
    public GameObject imgBienvenido;
    public GameObject imgError;
    public GameObject imgReestablecer;
    //  [SerializeField] private Persistencia datosUsuario;


    public void CambiarContra()
    {
        if (inpUserName.text != "" & inpEmail.text != "" )
        {
            StartCoroutine(ReestablecerContra());
        }
        else
        {
            imgError.SetActive(true);
            mensajeError.text = "Tienes que llenar todos los datos para cambiar tu contraseña";
        }
        
    }
    IEnumerator ReestablecerContra()
    {
        imgLoading.SetActive(true);
        string[] datos = new string[3];
        datos[0] = inpEmail.text;
        datos[1] = inpUserName.text;
        datos[2] = inpNuevoPass.text;

        StartCoroutine(servidor.ConsumirServicio("CambiarPass", datos));
        yield return new WaitForSeconds(1.0f);
        yield return new WaitUntil(() => !servidor.ocupado);
        imgLoading.SetActive(false);
        if (servidor.resp.codigo == 206)
        {
            Debug.Log("Contraseña actualizada correctamente....");
            Debug.Log(servidor.resp.respuesta);
           // usuario = JsonUtility.FromJson<UsuarioDB>(servidor.resp.respuesta);

            mensajeBienvenido.text = servidor.resp.respuesta + "\n Se ha cambiado tu contraseña correctamente, puedes iniciar sesion";
            imgBienvenido.SetActive(true);
            /*PlayerPrefs.SetString("Email", usuario.email);
            PlayerPrefs.SetString("UserName", usuario.user_name);*/
            // Debug.Log("Sesion iniciada correctamente");
            //  datosUsuario.AsignarDatos(servidor.resp.respuesta, "jajaja");
            //ControladorDatos.Instance.LlenarDatos(servidor.resp.respuesta, datos[0]);
        }
        else
        {
            Debug.Log("Algo salio mal :(");
            mensajeError.text = servidor.resp.respuesta;
            imgError.SetActive(true);
            // Debug.Log("Fallamos");
        }
    }

    public void Continuamos()
    {
        inpEmail.text = "";
        inpUserName.text = "";
        inpNuevoPass.text = "";
        imgBienvenido.SetActive(false);
        imgReestablecer.SetActive(false);
    }
}
