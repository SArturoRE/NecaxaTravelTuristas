using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Librerias que necesitamos para generar el codigo
using ZXing;
using ZXing.QrCode;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class QRCodeGenerator : MonoBehaviour
{
    [SerializeField]
    private RawImage imagenqueRecive;
    /*[SerializeField]
    private TMP_InputField textoInputFile;*/
    [SerializeField]
    private TMP_Text bienvenido;
    private Texture2D textoSinCodificar;

    private void Awake()
    {
        string email = PlayerPrefs.GetString("Email", "");
        string user = PlayerPrefs.GetString("UserName", "");
        if (email == "" || user == "")
        {
            SceneManager.LoadScene("LogIn");
        }
    }

    void Start()
    {
        textoSinCodificar = new Texture2D(256,256);
        bienvenido.text = "Bienvenid@ " + PlayerPrefs.GetString("UserName") + " Muestrale este codigo al encargado del negocio" +
            " para poder canjear tu recompensa";
        CodificandoTexto();
    }
    private Color32 [] Codificar(string textoACodificar, int width,int height)
    {
        BarcodeWriter writer = new BarcodeWriter
        {
            Format = BarcodeFormat.QR_CODE,
            Options = new QrCodeEncodingOptions
            {
                Height = height,
                Width = width,
            }
        };
        return writer.Write(textoACodificar);
    } 

    public void GeneraQR()
    {
        CodificandoTexto();
    }

    private void CodificandoTexto()
    {
        //string textWrite = string.IsNullOrEmpty(textoInputFile.text) ? "No has escrito nada compadre" : textoInputFile.text;
        string textWrite = PlayerPrefs.GetString("Email") + "*" + PlayerPrefs.GetString("UserName");
        Debug.Log(textWrite);
        Color32[] _convertirTextoATextura = Codificar(textWrite, textoSinCodificar.width, textoSinCodificar.height);
        textoSinCodificar.SetPixels32(_convertirTextoATextura);
        textoSinCodificar.Apply();

        imagenqueRecive.texture = textoSinCodificar;
    }
}
