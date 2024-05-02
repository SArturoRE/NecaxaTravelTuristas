using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private TMP_Text pregunta = null;
    [SerializeField] private List<OptionButons> m_buttonList = null;


    public void Construc(Question q, Action<OptionButons> call)
    {
        pregunta.text = q.textQuestion;

        for (int i = 0; i < m_buttonList.Count; i++)
        {
            m_buttonList[i].Constructor(q.opciones[i], call);
        }
    }


}

