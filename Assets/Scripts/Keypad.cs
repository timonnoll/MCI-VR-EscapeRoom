using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Keypad : MonoBehaviour
{
    [SerializeField] private TMP_Text Ans;
    [SerializeField] private Animator Door;

    private string Answer = "1976";

    public void Number(int number)
    {
        Ans.text += number.ToString();
    }

    public void Execute()
    {
        if(String.Equals(Ans.text, Answer) == true)
        {
            Ans.text = "Correct";
            Door.SetBool("Open", true);
            StartCoroutine("StopDoor");
        }
        else
        {
            Ans.text = "Invalid";
		Ans.text = "";	
        }
    }

    IEnumerator StopDoor()
    {
        yield return new WaitForSeconds(0.5f);
        Door.SetBool("Open", false);
        Door.enabled = false;
    }
}
