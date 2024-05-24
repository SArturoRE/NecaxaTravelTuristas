using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InformacionTurvina : MonoBehaviour
{
    /*Aqui iremos colocando los elementos que vamos a utilizar, siendo asi
     que la malloria de los elementos se registraran como Game Object para tener
    mejor control sobre ellos*/
    //pediremos el panel en donde se mostrara la informacion, es decir el texto que recabamos.
    [SerializeField] private TMP_Text contenido;
    //aqui controlamos los Game object del contenido que mostraremos, las imagenes que mostraremos en esta version
    [SerializeField] private GameObject[] imagenes = new GameObject[5];
    /*[SerializeField] private GameObject necaxaAntiguo;
    [SerializeField] private GameObject cascadaSalto;
    [SerializeField] private GameObject canaditas;*/
    [SerializeField] private GameObject sme;
    //Aqui inicializaremos los Game Objects para poder controlar el contenido que mostraremos
    [SerializeField] private GameObject btnSiguiente;
    [SerializeField] private GameObject btnAnterior;
    [SerializeField] private GameObject btnProximaScene;
    
    //Objetos para controlar los prefabs
    [SerializeField] private GameObject[] flechaImagenes = new GameObject[3];
  /*  [SerializeField] private GameObject flechaturbina;
    [SerializeField] private GameObject flechaPlaca;*/
    [SerializeField] private GameObject flechaDireccion;
    [SerializeField] private GameObject flechaDireccion2;
    [SerializeField] private GameObject angelDelTurismo;
    [SerializeField] private GameObject cuadroImagenes;
    [SerializeField] private GameObject cuadro2;


    //Colocaremos los botones para controlar cuando se muestran y cuando no.
    string[] contenidoTextTur = {
   "Comenzamos, recuerda disfrutar el contenido. La aplicación te irá mostrando unas flechas las cuales te muestran dónde se presentará el contenido o, en algunos casos, te mostrará monumento a los que la lectura está haciendo referencia y al último, estas te indicarán la dirección del próximo punto de la visita.",
    "A principios de 1850 Don José Justo Gómez, Conde de la Cortina, hizo una visita a la zona de necaxa, poblado en su mayoría por otomíes.",
    "Y quedo maravillado por las impresionantes cascadas de Salto Chico y Salto Grande, las cuales formaban parte del río Necaxa.",
    "Al iniciar la colonización de la mesa de Metlaltoyuca o de Coroneles, un francés, el Dr. Vaquiere descubrió las posibilidades industriales de las aguas del río Necaxa.",
    "Entonces abandono su idea de dedicarse a la agricultura y regresó a la Ciudad de México en donde obtuvo la formación de la compañía 'La Societe de Necaxa'.",
    "Logrando su fundación el 25 de junio de 1895 y fue en un lapso de 5 años donde reunió el capital suficiente para iniciar sus labores.",
    "Comisionando a los ingenieros Emilio Dessirnes, René Frouttuer y Alberto González para adquirir los terrenos de Salto Chico y la Mesa de las Flores.",
    "Conocido en la actualidad como 'La Mesita', a su propietario Cipriano Garrido Amador, verificándose el traslado de dichos predios por la suma de $1800.00 oro nacional.",
    "Reubicando a los pobladores originales en Necaxa Canaditas, aunque algunos de los pobladores no quisieron ser reubicados en canaditas y se distribuyeron en otros poblados.",
    "Como en el 'Cerro' Xoxocotlale (Necaxa del cerro), así como en pueblos circunvecinos de San Miguel Acuaucla y Santiago Patoltecoya.",
    "En 1902 se disuelve 'La societe de Necaxa' por falta de recursos y para continuar con los trabajos de la construcción de la presa de necaxa la 'The Mexican Light Power Company Limited'.",
    "En 1903 el 24 de marzo del gobierno de Porfirio Díaz, cede en contrato a la Mexican Light, el control sobre todas las aguas de necaxa.",
    "En 1906, quedan instaladas completamente las 6 primeras unidades de la planta de Necaxa con una capacidad de 37,500 kWh, funcionando con turbinas como la que tenemos en este monumento.",
    "Si te diriges al punto que se te está señalando con la flecha, podrás encontrar una placa que conmemora los 100 años de la fundación de Luz Y Fuerza del Centro los cuales se cumplieron en 2003.",
    "En 1911 inicia a tomar forma la unidad de los trabajadores para organizar un grupo que defienda sus intereses.",
    "en 1914 se funda el Sindicato Mexicano de Electricistas, siendo el primer secretario general el Sr. Luis R. Ochoa y el primer Sub. Secr. General Pedro Campos.",
    "Nota: si te encuentras aún enfrente de la placa de los 100 años, a tus espaldas, encontraras el edificio del SME.",
    "1930 En el lugar que hoy ocupa la clínica del seguro social, se inauguró el primer edificio del SME y terminan las reuniones en el local del Sr. Cleto Guzmán García.",
    "Por favor diríjase al siguiente punto (Plaza armada de México)"
    };
    private int i = 0;

    void Update()
    {
        contenido.text = contenidoTextTur[i];
    }

    public void ActualizaContenido()
    {
        if (i < contenidoTextTur.Length - 1)
        {
            i++;
        }

        MostrarContenido();
    }
    public void Anterior()
    {
        if (i > 0)
        {
            i--;
        }
        MostrarContenido();
    }

    public void CambaScene()
    {
        SceneManager.LoadScene("PlazaCivicaJG");
    }

    public void MostrarContenido()
    {
        switch (i)
        {
            case 0:
                btnAnterior.SetActive(false);
                flechaImagenes[2].SetActive(false);
                cuadroImagenes.SetActive(false);
                angelDelTurismo.SetActive(true);
                break;
            case 1:
                angelDelTurismo.SetActive(false);
                btnAnterior.SetActive(true);
                cuadroImagenes.SetActive(true);
                flechaImagenes[2].SetActive(true);
                imagenes[0].SetActive(true);
                imagenes[1].SetActive(false);
                break;
            case 2:
                imagenes[1].SetActive(true);
                imagenes[0].SetActive(false);
                break;
            case 3:
                imagenes[0].SetActive(true);
                imagenes[1].SetActive(false);
                break;
            case 7:
                imagenes[0].SetActive(true);
                imagenes[2].SetActive(false);
                break;
            case 8:
                imagenes[0].SetActive(false);
                imagenes[2].SetActive(true);
                break;
            case 9:
                imagenes[0].SetActive(false);
                imagenes[2].SetActive(true);
                imagenes[4].SetActive(false);
                break;
            case 10:
                imagenes[2].SetActive(false); 
                imagenes[4].SetActive(true);
                break;
            case 11:
                flechaImagenes[0].SetActive(false);
                flechaImagenes[2].SetActive(true);
                // flechaturbina.SetActive(false);
                imagenes[4].SetActive(true);
                cuadroImagenes.SetActive(true);
                break;
            case 12:
               
                flechaImagenes[0].SetActive(true);
                flechaImagenes[2].SetActive(false);
                flechaImagenes[1].SetActive(false);
                cuadroImagenes.SetActive(false);
               /* flechaturbina.SetActive(true);
                flechaPlaca.SetActive(false);*/
                break;
            case 13:
                flechaImagenes[0].SetActive(false);
                flechaImagenes[1].SetActive(true);
               /* flechaturbina.SetActive(false);
                flechaPlaca.SetActive(true);*/
                break;
            case 14:
                //flechaPlaca.SetActive(true);
                flechaImagenes[1].SetActive(true);
                cuadroImagenes.SetActive(false);
                cuadro2.SetActive(false);
                break;
            case 15:
                
                cuadro2.SetActive(true);
                flechaImagenes[1].SetActive(false);
                //flechaPlaca.SetActive(false);
                break;
            case 17:
                flechaImagenes[1].SetActive(false);
                //flechaPlaca.SetActive(false);
                cuadro2.SetActive(true);
                btnProximaScene.SetActive(false);
                btnSiguiente.SetActive(true);
                flechaDireccion.SetActive(false);
                flechaDireccion2.SetActive(false);
                break;
            case 18:
                btnSiguiente.SetActive(false);
                cuadro2.SetActive(false);
                btnProximaScene.SetActive(true);
                flechaDireccion.SetActive(true);
                flechaDireccion2.SetActive(true);
                break;

        }
    }
}
