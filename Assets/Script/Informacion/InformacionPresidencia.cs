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
    "Para concluir queremos contarte de algunas costumbres que se tienen en Juan Galindo, como la Religión, los medios de comunicación, deportes, etc.",
    "Religión: Predomina la religión católica, pero también existen sectas como la evangélica, pentecostés, espiritistas, etc. Cada una de ellas cuenta con su propio templo.",
    "Deportes: En este aspecto se practican los deportes como, básquet bol, voleibol, frontenis, beisbol, billar, squash y principalmente el futbol.",
    "Ferias: La feria se realza la intervención de algunos descendientes náhuatl, cuya veneración es a su santo San Cristóbal, al cual le rinden ritos, bailes.",
    "Así como la impresionante danza de los voladores y danza de las flores. La elaboración de coronas y collares, previo a la feria en el domicilio del mayordomo.",
    "Las auténticas raíces no han desaparecido, la festividad de todos los santos y fieles difuntos, el 1 y 2 de noviembre, se llevan a cabo los bonitos altares adornados con flor de cempasúchil.",
    "El pueblo se dedicaba principalmente a laborar en la empresa Luz y Fuerza del Centro, empresa que era el principal ingreso de la mayoría de los habitantes de Juan Galindo.",
    "Teniendo un gran impacto en la economía cuando el 11 de octubre de 2009, por decreto presidencial, se dispuso la extinción de Luz y fuerza del Centro.",
    "Con lo que se inició su proceso de liquidación administrativa, en tanto la operación eléctrica se transfirió a la Comisión Federal de Electricidad.",
    "Con esto damos por concluido el recorrido, espero te guste esta experiencia y ahora pasaremos a una trivia, para que tengas la oportunidad de ganar algún premio",
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
                cuadroImagenes[0].SetActive(false);
                btnAnterior.SetActive(false);
                break;
            case 1:
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
                break;
            case 3:
                /* cuadroImagenes.transform.position = new Vector3(2.1099999f, 0.85710001f, -0.610000014f);
                 cuadroImagenes.transform.rotation = Quaternion.Euler(270f, 149.588409f, 0f);*/
                cuadroImagenes[0].SetActive(false);
                cuadroImagenes[1].SetActive(true);

                break;
            case 4:
                igesiaCanaditas.SetActive(false);
                feria.SetActive(true);
                break;
            case 5:
                /* cuadroImagenes.transform.position = new Vector3(2.1099999f, 0.85710001f, -0.610000014f);
                 cuadroImagenes.transform.rotation = Quaternion.Euler(270f, 149.588409f, 0f);*/
                cuadroImagenes[2].SetActive(false);
                cuadroImagenes[1].SetActive(true);
                break;
            case 6:
                /* cuadroImagenes.transform.position = new Vector3(7.28999996f, 0.85710001f, 2.43000007f);
                 cuadroImagenes.transform.rotation = Quaternion.Euler(270f, 185.36261f, 0f);*/
                cuadroImagenes[1].SetActive(false);
                cuadroImagenes[2].SetActive(true);
                break;
            case 8:
                feria.SetActive(false);
                centralHid.SetActive(true);
                break;
            case 9:
                cuadroImagenes[2].SetActive(true);
                angelDelTurismo.SetActive(false);
                btnProximaScene.SetActive(false);
                btnSiguiente.SetActive(true);
                break;
            case 10:
                cuadroImagenes[2].SetActive(false);
                angelDelTurismo.SetActive(true);
                btnProximaScene.SetActive(true);
                btnSiguiente.SetActive(false);
                break;
        }
    }

    /*
     * Posicion Original
     * 
     * position Vector3(-3.36999989,0.85710001,-4.86000013)
     * rotation Vector3(270,137.487976,0)
     * 
     * 
     * p1
     * position Vector3(2.1099999,0.85710001,-0.610000014)
     * rotation Vector3(270,149.588409,0)
     * 
     * 
     * 
     * p2
     * 
     * position Vector3(7.28999996,0.85710001,2.43000007)
     * rotation Vector3(270,185.36261,0)
     */
}
