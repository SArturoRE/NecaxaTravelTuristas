using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InformacionPlazaCiviva : MonoBehaviour
{
    //pediremos el panel en donde se mostrara la informacion, es decir el texto que recabamos.
    [SerializeField] private TMP_Text contenido;
    //aqui controlamos los Game object del contenido que mostraremos, las imagenes que mostraremos en esta version
    [SerializeField] private GameObject[] cuadroImagenes = new GameObject[3];
    [SerializeField] private GameObject placaNecaxa;
    [SerializeField] private GameObject centralHidro;
    [SerializeField] private GameObject venustianoCarr;
    [SerializeField] private GameObject trenNec;
    [SerializeField] private GameObject trenNec2;
    //Aqui inicializaremos los Game Objects para poder controlar el contenido que mostraremos
    [SerializeField] private GameObject btnSiguiente;
    [SerializeField] private GameObject btnAnterior;
    [SerializeField] private GameObject btnProximaScene;

    //Objetos para controlar los prefabs
    [SerializeField] private GameObject flechaImagenes;
    [SerializeField] private GameObject flechaDireccion;
    [SerializeField] private GameObject angelDelTurismo;

    //Colocaremos los botones para controlar cuando se muestran y cuando no.
    string[] contenidoPlaza = {
    "Nos encontramos en el atrio de la plaza cívica Armada de México y te diremos más eventos interesantes de Juan Galindo, por favor dirígete al frente.",
    "¿Por qué lo llamamos Necaxa?",
    "La verdadera etimología de Necaxa nadie la ha podido explicar.",
    "Algunos piensan que se deriva de la palabra náhuatl NICATITLAZA, que significa tierras hundidas.",
    "Otras personas sostienen que es de MICATLA, que significa hilo o salto de agua.",
    "También se asegura que NECAXA tiene su origen en las dicciones aztecas: NEMI, verbo que significa habitar.",
    "CAXITL, cuyo significado se refiere a la escudilla que los indígenas llaman cajete.",
    "Y ATL, que quiere decir Agua, de esta manera la unión de estas radicales forman el vocablo NECAXATL que significa:",
    "Habitantes del cajete del agua o Moradores de la concavidad del río.",
    "Un historiador originario de Huauchinango, señala que el nombre procede de NECAXL, cuya denominación sería: Aquí se llena.",
    "Corrompida naturalmente con el transcurso del tiempo y sabiendo, sobre todo, que los indígenas acostumbraban señalar o fijar los nombres de sus lugares de residencia automáticamente.",
    "Se pienza también, que el nombre bien podría provenir de NACAXANCO, que significa allá en el agujero o allá en el hoyo.",
    "De lo anterior se puede señalar que los vocablos aceptados y adoptados por la población con base en los estudios realizados son:",
    "NEMI CAXITL ATL, cuyo significado se transcribe a: Moradores del cajete de agua o concavidad del río.",
    "En 1954 el C: Adolfo Ruiz Cortinez, Presidente de la república, inaugura la planta de patla.",
    "En 1960 El día 27 de septiembre el presidente de la república, Adolfo López Máteos nacionaliza la industria Eléctrica de México.",
    "Como dato curioso el 23 de mayo de 1920 se recibe el cuerpo en Villa Juárez, donde se le realiza la autopsia.",
    "Está estuvo a cargo de 2 médicos de Necaxa, el Dr. Carlos Sánchez Pérez médico de la Compañía de Luz y Fuerza, y el Dr. Armando Roberto Avellaneda Rosete, boticario del Pueblo.",
    "Posterior a la realización de los honores fúnebres y de haber designado a Villa Juárez como la Capital del País durante 3 días, se procede al penoso traslado del cuerpo hacia la ciudad de México.",
    "Es de resaltar que el vagón destinado para transportar el cuerpo fue el vagón El Carmen, el vagón de lujo de la empresa, que transportó a 5 Presidentes de la República en sus distintas visitas a Necaxa.",
    "Ya casi terminamos, podrías dirigirte a la Presidencia, que esta a tus espaldas (Solo ve en la dirección que te indica la flecha).",
    };
    private int i = 0;

    void Update()
    {
        contenido.text = contenidoPlaza[i];
    }

    public void ActualizaContenido()
    {

       // Debug.Log("Entre al metodo");
        if (i < contenidoPlaza.Length - 1)
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
        SceneManager.LoadScene("PrecidensiaMunicipal");

        /*posicion Vector3(-1.28999996,2.43000007,-3.8900001)
         * rotacion Vector3(-1.28999996,2.43000007,-3.8900001)
         */
    }

    public void MostrarContenido()
    {
        switch (i)
        {
            case 0:
                btnAnterior.SetActive(false);
                angelDelTurismo.transform.position = new Vector3(-1.50999999f, 1.90999997f, -8.31000042f);
                angelDelTurismo.transform.rotation = Quaternion.Euler(1.63396776f, 44.2113724f, 356.241333f);
                flechaImagenes.SetActive(true);
                break;
            case 1:
                flechaImagenes.SetActive(false);
                btnAnterior.SetActive(true);
                angelDelTurismo.transform.position = new Vector3(-1.28999996f, 2.43000007f, -3.8900001f);
                angelDelTurismo.transform.rotation = Quaternion.Euler(4.52634566e-07f, 272.923553f, 1.15504752e-08f);
                cuadroImagenes[0].SetActive(false);
                angelDelTurismo.SetActive(true);
                break;
            case 2:
                angelDelTurismo.SetActive(false);
                cuadroImagenes[0].SetActive(true);
                break;
            case 5:
                placaNecaxa.SetActive(true);
                centralHidro.SetActive(false);
                break;
            case 6:
                placaNecaxa.SetActive(false);
                centralHidro.SetActive(true);
                cuadroImagenes[1].SetActive(false);
                cuadroImagenes[0].SetActive(true);
                break;
            case 7:
                cuadroImagenes[0].SetActive(false);
                cuadroImagenes[1].SetActive(true);
                break;
            case 8:
              /*  cuadroImagenes.transform.position = new Vector3(1.43094063f, 1.39999998f, 1.31682158f);
                cuadroImagenes.transform.rotation = Quaternion.Euler(270f, 113.734909f, 0f);
                */
                break;
            case 9:
                /* trenNec.SetActive(false);
                 trenNec2.SetActive(true);*/
                //trenNec.SetActive(true);
               // trenNec2.SetActive(false);
                break;
            case 10:
                trenNec.SetActive(false);
                venustianoCarr.SetActive(true);
                break;
            case 11:
                venustianoCarr.SetActive(false);
                trenNec.SetActive(true); 
                break;
            case 14:
                /* cuadroImagenes.transform.position = new Vector3(1.43094063f, 1.39999998f, 1.31682158f);
                 cuadroImagenes.transform.rotation = Quaternion.Euler(270f, 113.734909f, 0f);*/
                cuadroImagenes[1].SetActive(true);
                cuadroImagenes[2].SetActive(false);
                //trenNec2.SetActive(false);
                //centralHidro.SetActive(true);
                break;
            case 15:
                cuadroImagenes[1].SetActive(false);
                cuadroImagenes[2].SetActive(true);
                break;
            case 19:
                btnSiguiente.SetActive(true);
                btnProximaScene.SetActive(false);
                flechaDireccion.SetActive(false);
                break;
            case 20:
                angelDelTurismo.transform.position = new Vector3(3.20000005f, 2.17000008f, -1.70000005f);
                angelDelTurismo.transform.rotation = Quaternion.Euler(356.077057f, 307.583221f, 358.814117f);
                flechaDireccion.SetActive(true);
                btnSiguiente.SetActive(false);
                btnProximaScene.SetActive(true);
                break;
        }
    }
}


/*
 * Position Vector3(0.870000005,1.39999998,-2.6400001)
 * Rotation Vector3(270,98.0291748,0)
 * 
 * 
 * Position Vector3(1.43094063,1.39999998,1.31682158)
 * Rotation Vector3(270,113.734909,0)
 * 
 * 
 * Position Vector3(3.26999974,1.39999998,5.48999929)
 * Rotation Vector3(270,149.491653,0)
 */