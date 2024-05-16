using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InformacionCoronelJG : MonoBehaviour
{
    [SerializeField] private TMP_Text contenido;
    [SerializeField] private GameObject cuadro;
    [SerializeField] private GameObject cuadro2;
    [SerializeField] private GameObject[] imagenesCuadro1 = new GameObject[4];
    [SerializeField] private GameObject[] imagenesCuadro2 = new GameObject[4];
   /* [SerializeField] private GameObject idoloJade;
    [SerializeField] private GameObject bailFlores;
    [SerializeField] private GameObject necaxAntiguo;
    [SerializeField] private GameObject nuevoNecaxa;*/
    [SerializeField] private GameObject angelDelTurismo;
    [SerializeField] private GameObject flechaimagenes;
    [SerializeField] private GameObject flechaimagenes2;
    [SerializeField] private GameObject flechaCJG;
    [SerializeField] private GameObject flechaSiguienteP;

    [SerializeField] private GameObject otraScene;
    [SerializeField] private GameObject siguiente;
    [SerializeField] private GameObject anterior;


    string[] contenidoTextCJG = {
    "Te encuentras en el sitio correcto",
    "Hola, soy el ángel turista de esta aplicación y hoy vengo a hablarte del municipio de Juan Galindo",
    "Siendo un pueblo que data de la época Precortesiana, se ignora la fecha de su fundación.",
    "Se considera que fue fundado antes de la conquista, por lo cual se considera un pueblo de origen Náhuatl.",
    "Pero se cree que los olmecas también habitaron por estos rumbos, debido a que en 1909 mientras se rascaba para la creación del muro de la presa.",
    "Se encontró un ídolo de jade verde, el cual se encuentra en el salón de México del museo de historia natural de Nueva York.",
    "Dentro de sus ritos, costumbres y vestimenta, tenemos hasta la fecha que sigue vigente el baile de las flores.",
    "Antes de ser Juan Galindo, Necaxa era un pueblo dedicado a la siembra de maíz, cría de ganado, aves de corral y la fabricación de teja para los techados.",
    "En la escuela se tomaban clases impartidas por el maestro que llegaba de huauchinango a caballo todos los días",
    "Para impartir clases de primaria en un salón grande distribuido para primero, segundo y tercero.",
    "El sacerdote que los asistía de la religión católica llegaba de huauchinango a caballo los días domingos y festivos",
    "En 1866 el teniente Juan Galindo obtuvo el triunfo ante el ejército francés en tecacalango Puebla",
    "Ganándose así el título de Coronel y es por el que el municipio lleva su nombre.",
    "El día 27 de agosto de 1923 se dictó un decreto oficial que dice primordialmente lo siguiente:",
    "“27 de agosto de 1923, el lugar denominado 'El Campamento' llevará la denominación de “Nuevo Necaxa” y el cual se conoce por el de “Canaditas” seguirá denominándose “Necaxa””.",
    "Diríjase al siguiente punto..."
    };
    int i = 0;
    private void Update()
    {
        contenido.text = contenidoTextCJG[i];
    }
    public void CambiaScene()
    {
        SceneManager.LoadScene("TurbinaElectrica");
    }
    public void ActualizaContenido()
    {
        if (i < contenidoTextCJG.Length - 1)
        {
            i++;
        }

        if(i > 0)
        {
            anterior.SetActive(true);
        }

        PublicaContenido();
    }
    public void Anterior()
    {
        i--;
        PublicaContenido();
    }

    public void PublicaContenido()
    {
        switch (i)
        {
            case 0:
                anterior.SetActive(false);
                angelDelTurismo.SetActive(false);
                break;
            case 1:
                angelDelTurismo.SetActive(true);
                break;
            case 4:
                angelDelTurismo.SetActive(true);
                cuadro.SetActive(false);
                flechaimagenes.SetActive(false);
                break;
            case 5:
                angelDelTurismo.SetActive(false);
                flechaimagenes.SetActive(true);
                cuadro.SetActive(true);
                imagenesCuadro1[0].SetActive(true);
                imagenesCuadro1[1].SetActive(false);
                break;
            case 6:
                imagenesCuadro1[0].SetActive(false);
                imagenesCuadro1[1].SetActive(true);
                break;
            case 10:
                flechaimagenes.SetActive(true);
                cuadro.SetActive(true);
                flechaCJG.SetActive(false);
                break;
            case 11:
                cuadro.SetActive(false);
                flechaimagenes.SetActive(false);
                flechaCJG.SetActive(true);
                break;
            case 12:
                flechaCJG.SetActive(true);
                flechaimagenes2.SetActive(false);
                cuadro2.SetActive(false);
                break;
            case 13:
                flechaCJG.SetActive(false);
                flechaimagenes2.SetActive(true);
                cuadro2.SetActive(true);
                break;
            case 14:
                flechaimagenes2.SetActive(true);
                cuadro2.SetActive(true);
                imagenesCuadro2[0].SetActive(false);
                imagenesCuadro2[1].SetActive(true);
                siguiente.SetActive(true);
                otraScene.SetActive(false);
                flechaSiguienteP.SetActive(false);
                break;
            case 15:
                flechaimagenes2.SetActive(false);
                cuadro2.SetActive(false);
                flechaSiguienteP.SetActive(true);
                otraScene.SetActive(true);
                siguiente.SetActive(false);
                break;
        }
    }


}
