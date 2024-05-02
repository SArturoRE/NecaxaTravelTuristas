using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarScene : MonoBehaviour
{
    [SerializeField] private string scenemove = "";

    public void ChangeScene()
    {
        SceneManager.LoadScene(scenemove);
    }

    public void SalirdeApp()
    {

        Debug.Log("Cerramos la aplicacion...");
        Application.Quit();
    }
}
