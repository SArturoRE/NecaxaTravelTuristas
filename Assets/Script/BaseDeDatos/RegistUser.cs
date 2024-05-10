using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static Respuesta;

public class RegistUser : MonoBehaviour
{
    public Servidor servidor;
    public UsuarioDB user;
    [SerializeField] private SendEmail sendCorreo;
    public TMP_InputField inpName;
    public TMP_InputField inpUserName;
    public TMP_InputField inpEmail;
    public TMP_InputField inpPass;
    public TMP_Text nombre;
    public TMP_Text mensajeError;
    public GameObject imgLoading;
    public GameObject imgBienvenido;
    public GameObject imgError;


    private void Awake()
    {
        string userN = PlayerPrefs.GetString("UserName","");
        string email = PlayerPrefs.GetString("Email", "");

        if (userN != "" & email != "")
        {
            SceneManager.LoadScene("Menú");
        }
    }

    public void RegistrarUser()
    {
        if (inpName.text != "" & inpUserName.text != "" & inpEmail.text != "" & inpPass.text != "")
        {
            StartCoroutine(RegistrarUsuario());
        }
        else
        {
            imgError.SetActive(true);
            mensajeError.text = "Tienes que llenar todos los datos para realizar el registro";
        }
        
    }
    IEnumerator RegistrarUsuario()
    {
       
        imgLoading.SetActive(true);
        string[] datos = new string[4];
        datos[0] = inpName.text;
        datos[1] = inpUserName.text;
        datos[2] = inpEmail.text;
        datos[3] = inpPass.text;

        StartCoroutine(servidor.ConsumirServicio("registrar", datos));
        yield return new WaitForSeconds(1.0f);
        yield return new WaitUntil(() => !servidor.ocupado);
        imgLoading.SetActive(false);
        if (servidor.resp.codigo == 201)
        {
            user = JsonUtility.FromJson<UsuarioDB>(servidor.resp.respuesta);
            sendCorreo.EnviarCorreo(user.nombre,user.email);
            PlayerPrefs.SetString("Email",user.email);
            PlayerPrefs.SetString("UserName",user.user_name);
            nombre.text = "Bienvenid@ " + user.user_name + "\n Ahora ya tienes un usuario creado...";
            imgBienvenido.SetActive(true);
        }else
        {
            mensajeError.text = "Ups!!! Algo salio mal, intentalo de nuevo";
            imgError.SetActive(true);
        }
    }

    public void Limpiar()
    {
        inpName.text = "";
        inpUserName.text = "";
        inpEmail.text = "";
        inpPass.text = "";
        imgError.SetActive(false);
    }


}
