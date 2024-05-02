using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Respuesta;

public class Perfil : MonoBehaviour
{
    public Servidor servidor;
   /* public TMP_InputField inpEmail;
    public TMP_InputField inpuserName;*/
    public GameObject imgLoading;
    public UsuarioDB usuario;

    //Campos donde mostraremos los datos

    public TMP_Text nombre;
    public TMP_Text userName;
    public TMP_Text correo;
    public TMP_Text puntosObt;


    private void Awake()
    {
        Debug.Log("Entro el proseso...");
        string email = PlayerPrefs.GetString("Email", "");
        string userName = PlayerPrefs.GetString("UserName", "");
        //Debug.Log(email + "  " + userName);
        if (email == "" && userName == "")
        {
            SceneManager.LoadScene("Menú");
        }
    }
    public void Start()
    {
        StartCoroutine(DatosPerfil());
    }
    IEnumerator DatosPerfil()
    {
        Debug.Log(PlayerPrefs.GetString("Email") + "\n" + PlayerPrefs.GetString("UserName"));

        //imgLoading.SetActive(true);
        string[] datos = new string[2];
        datos[0] = PlayerPrefs.GetString("UserName");//ControladorDatos.Instance.Username;
        datos[1] = PlayerPrefs.GetString("Email");//ControladorDatos.Instance.Email;

        StartCoroutine(servidor.ConsumirServicio("perfil", datos));
        yield return new WaitForSeconds(1.0f);
        yield return new WaitUntil(() => !servidor.ocupado);
        imgLoading.SetActive(false);
        if (servidor.resp.codigo == 205)
        {
            //mensajeBienvenido.text = servidor.resp.respuesta + "\n Has iniciado sesion, podemos comenzar";
            // imgBienvenido.SetActive(true);
            // Debug.Log("Sesion iniciada correctamente");
            
            Debug.Log(servidor.resp.respuesta);

            usuario = JsonUtility.FromJson<UsuarioDB>(servidor.resp.respuesta);

            nombre.text = usuario.nombre;
            userName.text = usuario.user_name;
            correo.text = usuario.email;
            puntosObt.text = usuario.puntos_obtenidos.ToString();
        }
        else
        {
           // mensajeError.text = servidor.resp.respuesta;
           // imgError.SetActive(true);
             Debug.Log("Fallamos");
        }
    }
}
