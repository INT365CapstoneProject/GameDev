using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour

{
    [SerializeField] private Text Ans;
    [SerializeField] private Animator Door;
    private string Answer = "123456";
    

    public void Number(int number)
    {
        Ans.text += number.ToString();
        
    }
    public void Execute()
    {
        if(Ans.text == Answer)
        {
            Ans.text = "Correct";
            StartCoroutine(CooldownClose());
        }
        else
        {
            Ans.text = "Invalid";
            
        }
        StartCoroutine(CooldownText());
    }

    IEnumerator CooldownText()
    {
        yield return new WaitForSeconds(1.0f);
        Ans.text = "";
    }

    IEnumerator CooldownClose()
    {
        yield return new WaitForSeconds(2f);
        this.gameObject.SetActive(false);
    }



}
