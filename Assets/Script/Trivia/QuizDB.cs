using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class QuizDB : MonoBehaviour
{
    [SerializeField] private List<Question> questions = null;

    private List<Question> respaldo = null;

    private void Awake()
    {
        respaldo = questions.ToList();
    }
    public Question GetRandoom(bool remove = true)
    {

        if (questions.Count == 0)
        {
            YaNoHayPreguntas();
        }

        int index = Random.Range(0, questions.Count);

        if (!remove)
        {
            return questions[index];
        }
        Question q = questions[index];
        questions.RemoveAt(index);

        return q;
    }

    private void YaNoHayPreguntas()
    {
        questions = respaldo.ToList();
    }
}
