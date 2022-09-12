using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizTrig : MonoBehaviour
{
    public GameObject QuizText;
    public GameObject Quiz;
    [SerializeField] bool isshown = false;



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
           QuizText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            QuizText.SetActive(false);
            Quiz.SetActive(false);
            isshown = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        PressForQuiz();
    }
    public void PressForQuiz()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            QuizText.SetActive(false);
            Quiz.SetActive(true);
            isshown = true;
        }


    }
}
