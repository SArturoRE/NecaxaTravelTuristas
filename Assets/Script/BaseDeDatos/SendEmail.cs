using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Respuesta;
using UnityEngine.SceneManagement;

public class SendEmail : MonoBehaviour
{
    [SerializeField] private  Servidor servidor;
    public void EnviarCorreo(string nombre, string email)
    {
        StartCoroutine(SendEmailAceptado(nombre, email));
    }
    IEnumerator SendEmailAceptado(string name, string email)
    {
        string[] datos = new string[2];
        datos[0] = name;
        datos[1] = email;

        StartCoroutine(servidor.ConsumirServicio("SendEmail", datos));
        yield return new WaitForSeconds(1.0f);
        yield return new WaitUntil(() => !servidor.ocupado);
        if (servidor.resp.codigo == 208)
        {
            Debug.Log("El correo se envio correctamente");
        }
        else
        {
            Debug.Log("No se envio el correo");
        }
    }
}
