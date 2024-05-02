using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Respuesta;

public class ActualizarPuntos : MonoBehaviour
{
    public UsuarioDB usuario;
    public Servidor servidor;
    [SerializeField] TMP_Text puntajeFinal;
   

    public void SumaPuntos(int puntosN)
    {
        Debug.Log("Ponemos" + PlayerPrefs.GetString("Email") + PlayerPrefs.GetString("UserName"));
        StartCoroutine(ActPuntos(puntosN));
    }
    IEnumerator ActPuntos(int puntosNuevos)
    {
        //imgLoading.SetActive(true);
        string[] datos = new string[3];
        datos[0] = PlayerPrefs.GetString("UserName");
        datos[1] = PlayerPrefs.GetString("Email");
        datos[2] = puntosNuevos.ToString();

        StartCoroutine(servidor.ConsumirServicio("SumarPuntos", datos));
        yield return new WaitForSeconds(1.0f);
        yield return new WaitUntil(() => !servidor.ocupado);
        //imgLoading.SetActive(false);
        if (servidor.resp.codigo == 207)
        {
           Debug.Log("Puntaje actualizado Correctamente....");
            puntajeFinal.text = " Conseguiste: "+puntosNuevos+" puntos. \n Ahora tienes: " + servidor.resp.respuesta+" Puntos en total";           

        }
        else
        {
            Debug.Log("Algo salio mal :(");
            
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
