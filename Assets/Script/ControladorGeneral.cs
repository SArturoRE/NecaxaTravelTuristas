using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorGeneral : MonoBehaviour
{

    private void Start()
    {
        string email = PlayerPrefs.GetString("Email","");
        string user = PlayerPrefs.GetString("UserName","");
        if (email == "" || user == "")
        {
            SceneManager.LoadScene("LogIn");
        }

    }
    public void CerrarSesion()
    {
        PlayerPrefs.DeleteKey("Email");
        PlayerPrefs.DeleteKey("UserName");
        SceneManager.LoadScene("LogIn");
    }

    public void SalirdeApp()
    {
        Debug.Log("Cerramos la aplicacion...");
        Application.Quit();
    }
}
