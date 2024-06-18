using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using static Respuesta;


[CreateAssetMenu(fileName = "Servidor", menuName = "Sartres/Servidor", order = 1)]
public class Servidor : ScriptableObject
{
    public string servidor;
    public Servicio[] servicios;

    public bool ocupado = false;
    public Respuesta resp;


    public IEnumerator ConsumirServicio(string nombre, string[] datos)
    {
        ocupado = true;
        resp = new Respuesta();
        WWWForm formulario = new WWWForm();
        Servicio s = new Servicio();
        for (int i = 0; i < servicios.Length; i++)
        {
            if (servicios[i].nombre.Equals(nombre))
            {
                s = servicios[i];
            }
        }


        for (int i = 0; i < s.parametros.Length; i++)
        {
            formulario.AddField(s.parametros[i], datos[i]);
        }

        UnityWebRequest www = UnityWebRequest.Post(servidor + s.url, formulario);

        Debug.Log(servidor + s.url);
        // Debug.Log("Resp 1= " + www.result + " Respuesta 2 = " + UnityWebRequest.Result.Success);

        yield return www.SendWebRequest();

        //Debug.Log("Resp 1= "+www.result+" Respuesta 2 = "+ UnityWebRequest.Result.Success );

        if (www.result != UnityWebRequest.Result.Success)
        {
            //Debug.Log("ENTRE AL IF");
            resp = new Respuesta();
        }
        else
        {
            Debug.Log("Estoy en el else");
            Debug.Log(www.downloadHandler.text);
            resp = JsonUtility.FromJson<Respuesta>(www.downloadHandler.text);
            //user = JsonUtility.FromJson<DatosUsuario>(www.downloadHandler.text);
            resp.LimpiarRespuesta();
            // Debug.Log(resp);
            // respuestaCompleta.respuesta = resp.codigo;
        }

        ocupado = false;
    }
}

[System.Serializable]
public class Servicio
{
    public string nombre;
    public string url;
    public string[] parametros;
}

[System.Serializable]
public class Respuesta
{
    public int codigo;
    public string mensaje;
    public string respuesta;

    public void LimpiarRespuesta()
    {
        respuesta = respuesta.Replace('#', '"');
    }
    public Respuesta()
    {
        codigo = 404;
        mensaje = "Error";
    }

    [System.Serializable]
    public class UsuarioDB
    {
        public int id;
        public string nombre;
        public string user_name;
        public string email;
        public int puntos_obtenidos;
    }
}