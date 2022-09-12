using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeypadTrig : MonoBehaviour
{
    public GameObject keyText;
    public GameObject Keypad;
    [SerializeField] bool isshown = false;

    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            keyText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag =="Player")
        {
            keyText.SetActive(false);
            Keypad.SetActive(false);
            isshown = false;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        PressForKeypad();
    }
    public void PressForKeypad()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {            
                keyText.SetActive(false);
                Keypad.SetActive(true);
                isshown = true;                    
        }
        
        
    }
}
