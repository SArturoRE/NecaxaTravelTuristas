using System.Collections;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ControladorTrivia : MonoBehaviour
{
    [SerializeField] GameObject panelFinal;
    [SerializeField] private AudioClip m_correctSound = null;
    [SerializeField] private AudioClip m_failSound = null;
    [SerializeField] private Color m_colorCorrect = Color.white;
    [SerializeField] private Color m_colorFail = Color.white;
    [SerializeField] private float espera = 0.0f;
    [SerializeField] private int preguntas;
    [SerializeField] private TMP_Text puntaje;
    [SerializeField] private ActualizarPuntos nuePuntos;
    
    
    public int puntajeValor = 0;

    private QuizDB m_quizDB = null;
    private QuizUI m_quizUI = null;
    private AudioSource m_audioSource = null;

    private void Start()
    {
        m_quizDB = GameObject.FindObjectOfType<QuizDB>();
        m_quizUI = GameObject.FindObjectOfType<QuizUI>();
        m_audioSource = GetComponent<AudioSource>();
        preguntas = 0;
        NextQuestion();
    }
    private void Update()
    {
        puntaje.text = puntajeValor.ToString();
    }
    private void NextQuestion()
    {
        m_quizUI.Construc(m_quizDB.GetRandoom(), GiveAnsewer);

    }
    private void GiveAnsewer(OptionButons opSelec)
    {
        StartCoroutine(GiveAnswerRoutine(opSelec));
    }

    private IEnumerator GiveAnswerRoutine(OptionButons op)
    {
        if (m_audioSource.isPlaying)
        {
            m_audioSource.Stop();
        }

        preguntas++;

        if (op.Option.correct)
        {
            m_audioSource.clip = m_correctSound;
            op.SetColor(m_colorCorrect);
            puntajeValor += 50;
        }
        else
        {
            m_audioSource.clip = m_failSound;
            op.SetColor(m_colorFail);
            puntajeValor -= 5;
        }

        m_audioSource.Play();

        if (preguntas == 10)
        {
            panelFinal.SetActive(true);
            nuePuntos.SumaPuntos(puntajeValor);
        }

        yield return new WaitForSeconds(espera);

        NextQuestion();
    }
}
