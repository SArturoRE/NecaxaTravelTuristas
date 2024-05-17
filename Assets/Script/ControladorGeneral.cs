using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorGeneral : MonoBehaviour
{
    [SerializeField] private GameObject indicacionesPanel;

    private void Start()
    {
        string email = PlayerPrefs.GetString("Email","");
        string user = PlayerPrefs.GetString("UserName","");
        int menu = PlayerPrefs.GetInt("Menu");

        if (email == "" || user == "")
        {
            SceneManager.LoadScene("LogIn");
        }

        if (menu == 1)
        {
            indicacionesPanel.SetActive(false);
        }

    }
    public void CerrarSesion()
    {
        PlayerPrefs.DeleteKey("Email");
        PlayerPrefs.DeleteKey("UserName");
        PlayerPrefs.DeleteKey("Menu");
        SceneManager.LoadScene("LogIn");
    }
    public void AceptarMenu()
    {
        PlayerPrefs.SetInt("Menu",1);
    }

    public void SalirdeApp()
    {
        Debug.Log("Cerramos la aplicacion...");
        Application.Quit();
    }
}
