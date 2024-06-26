using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class InformacionPresidencia : MonoBehaviour
{
    //pediremos el panel en donde se mostrara la informacion, es decir el texto que recabamos.
    [SerializeField] private TMP_Text contenido;
    //aqui controlamos los Game object del contenido que mostraremos, las imagenes que mostraremos en esta version
    [SerializeField] private GameObject[] cuadroImagenes;
    [SerializeField] private GameObject[] flechasImagenes;
    [SerializeField] private GameObject igesiaNecaxa;
    [SerializeField] private GameObject igesiaCanaditas;
    [SerializeField] private GameObject feria;
    [SerializeField] private GameObject centralHid;
    //Aqui inicializaremos los Game Objects para poder controlar el contenido que mostraremos
    [SerializeField] private GameObject btnSiguiente;
    [SerializeField] private GameObject btnAnterior;
    [SerializeField] private GameObject btnProximaScene;

    //Objetos para controlar los prefabs
    
    [SerializeField] private GameObject angelDelTurismo;

    //Colocaremos los botones para controlar cuando se muestran y cuando no.
    string[] contenidoPresi = {
    "Comenzamos, recuerda disfrutar el contenido. La aplicaci�n te ir� mostrando unas flechas las cuales te muestran d�nde se presentar� el contenido o, en algunos casos, te mostrar� monumento a los que la lectura est� haciendo referencia y al �ltimo, estas te indicar�n la direcci�n del pr�ximo punto de la visita.",
    "Para concluir queremos contarte de algunas costumbres que se tienen en Juan Galindo, como la Religi�n, los medios de comunicaci�n, deportes, etc.",
    "Religi�n: Predomina la religi�n cat�lica, pero tambi�n existen sectas como la evang�lica, pentecost�s, espiritistas, etc. Cada una de ellas cuenta con su propio templo.",
    "Deportes: En este aspecto se practican los deportes como, b�squet bol, voleibol, frontenis, beisbol, billar, squash y principalmente el futbol.",
    "Ferias: La feria se realza la intervenci�n de algunos descendientes n�huatl, cuya veneraci�n es a su santo San Crist�bal, al cual le rinden ritos, bailes.",
    "As� como la impresionante danza de los voladores y danza de las flores. La elaboraci�n de coronas y collares, previo a la feria en el domicilio del mayordomo.",
    "Las aut�nticas ra�ces no han desaparecido, la festividad de todos los santos y fieles difuntos, el 1 y 2 de noviembre, se llevan a cabo los bonitos altares adornados con flor de cempas�chil.",
    "El pueblo se dedicaba principalmente a laborar en la empresa Luz y Fuerza del Centro, empresa que era el principal ingreso de la mayor�a de los habitantes de Juan Galindo.",
    "Teniendo un gran impacto en la econom�a cuando el 11 de octubre de 2009, por decreto presidencial, se dispuso la extinci�n de Luz y fuerza del Centro.",
    "Con lo que se inici� su proceso de liquidaci�n administrativa, en tanto la operaci�n el�ctrica se transfiri� a la Comisi�n Federal de Electricidad.",
    "Con esto damos por concluido el recorrido, espero te guste esta experiencia y ahora pasaremos a una trivia, para que tengas la oportunidad de ganar alg�n premio",
    "Suerte..."
    };
    private int i = 0;

    void Update()
    {
        contenido.text = contenidoPresi[i];
    }

    public void ActualizaContenido()
    {

        // Debug.Log("Entre al metodo");
        if (i < contenidoPresi.Length - 1)
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
        SceneManager.LoadScene("TriviaJG");
    }

    public void MostrarContenido()
    {
        switch (i)
        {
            case 0:
                flechasImagenes[0].SetActive(false);
                cuadroImagenes[0].SetActive(false);
                btnAnterior.SetActive(false);
                break;
            case 1:
                flechasImagenes[0].SetActive(true);
                cuadroImagenes[0].SetActive(true);
                btnAnterior.SetActive(true);
                igesiaNecaxa.SetActive(true);
                igesiaCanaditas.SetActive(false);
                break;
            case 2:
                igesiaNecaxa.SetActive(false);
                igesiaCanaditas.SetActive(true);
                /*cuadroImagenes.transform.position = new Vector3(-3.36999989f, 0.85710001f, -4.86000013f);
                cuadroImagenes.transform.rotation = Quaternion.Euler(270f, 137.487976f, 0f);*/
                cuadroImagenes[1].SetActive(false);
                cuadroImagenes[0].SetActive(true);
                flechasImagenes[1].SetActive(false);
                flechasImagenes[0].SetActive(true);
                break;
            case 3:
                flechasImagenes[0].SetActive(false);
                flechasImagenes[1].SetActive(true);
                cuadroImagenes[0].SetActive(false);
                cuadroImagenes[1].SetActive(true);

                break;
            case 4:
                igesiaCanaditas.SetActive(false);
                feria.SetActive(true);
                break;
            case 6:
                feria.SetActive(true);
                flechasImagenes[2].SetActive(false); 
                flechasImagenes[1].SetActive(true);
                cuadroImagenes[2].SetActive(false);
                cuadroImagenes[1].SetActive(true);
                break;
            case 7:
                flechasImagenes[1].SetActive(false);
                flechasImagenes[2].SetActive(true);
                cuadroImagenes[1].SetActive(false);
                cuadroImagenes[2].SetActive(true);
                break;
            case 8:
                feria.SetActive(false);
                centralHid.SetActive(true);
                break;
            case 10:
                cuadroImagenes[2].SetActive(true);
                flechasImagenes[2].SetActive(true);
                angelDelTurismo.SetActive(false);
                btnProximaScene.SetActive(false);
                btnSiguiente.SetActive(true);
                break;
            case 11:
                flechasImagenes[2].SetActive(false);
                cuadroImagenes[2].SetActive(false);
                angelDelTurismo.SetActive(true);
                btnProximaScene.SetActive(true);
                btnSiguiente.SetActive(false);
                break;
        }
    }

 
}
