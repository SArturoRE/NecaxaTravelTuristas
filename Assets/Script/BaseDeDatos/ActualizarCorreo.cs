using System.Collections;
using TMPro;
using UnityEngine;
using static Respuesta;

public class ActualizarCorreo : MonoBehaviour
{
    public UsuarioDB usuario;
    public Perfil perfilnuevo;
    public Servidor servidor;
    public TMP_InputField inpNuevoEmail;
    public TMP_InputField inpPass;
    public GameObject panelActualizaCorreo;
   /* public TMP_Text mensajeBienvenido;
    public TMP_Text mensajeError;
    public GameObject imgLoading;
    public GameObject imgBienvenido;
    public GameObject imgError;
    public GameObject imgReestablecer;*/


    public void ActualizaCorreo()
    {
        StartCoroutine(CambiaCorreo());
    }
    IEnumerator CambiaCorreo()
    {
        //imgLoading.SetActive(true);
        string[] datos = new string[3];
        datos[0] = PlayerPrefs.GetString("Email");
        datos[1] = inpPass.text;
        datos[2] = inpNuevoEmail.text;

        StartCoroutine(servidor.ConsumirServicio("ActualizaEmail", datos));
        yield return new WaitForSeconds(1.0f);
        yield return new WaitUntil(() => !servidor.ocupado);
        //imgLoading.SetActive(false);
        if (servidor.resp.codigo == 203)
        {
            Debug.Log("Correo Actualizado Correctamente....");
           // Debug.Log(servidor.resp.respuesta);
            PlayerPrefs.DeleteKey("Email");
            PlayerPrefs.SetString("Email",servidor.resp.respuesta);
            panelActualizaCorreo.SetActive(false);
            perfilnuevo.Start();
            
        }
        else
        {
            Debug.Log("Algo salio mal :(");
           // mensajeError.text = servidor.resp.respuesta;
            //imgError.SetActive(true);
            // Debug.Log("Fallamos");
        }
    }

    public void Continuamos()
    {
        /*inpEmail.text = "";
        inpUserName.text = "";
        inpNuevoPass.text = "";
        imgBienvenido.SetActive(false);
        imgReestablecer.SetActive(false);*/
    }
}
