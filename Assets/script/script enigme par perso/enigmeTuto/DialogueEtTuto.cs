using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEtTuto : MonoBehaviour
{
    public bool ActiveDialogue1;

    public bool ActiveDialogue2;

    public bool ActiveDialogue3;

    //public bool buttonPasserAutorisation;

    [SerializeField]
    GameObject buttonPasser;

    [SerializeField]
    GameObject dialoguepackage0;

    [SerializeField]
    GameObject dialoguepackage1;
    
    [SerializeField]
    GameObject dialoguepackage2;
    
    [SerializeField]
    GameObject dialoguepackage3;


    //[SerializeField]
    //GameObject[] dialoguepackage;

    public int dialogue;

    // Start is called before the first frame update
    void Start()
    {
        dialogue = 0;
        //dialoguepackage1.SetActive(true);

        //buttonPasserAutorisation = true;
        ActiveDialogue1 = false;
        ActiveDialogue3 = false;
        ActiveDialogue2 = false;
        dialoguepackage0.SetActive(false);
        //dialoguepackage1.SetActive(false);
        dialoguepackage2.SetActive(false);
        dialoguepackage3.SetActive(false);
    }




    public void passageDeDialogueButton()
    {
        Debug.Log("test");
        dialogue =+1;
        buttonPasser.SetActive(false);
        //buttonPasserAutorisation = false;
    }



    //public void passageDeDialogue (){

    //dialoguepackage1.SetActive(false);
    //}
    // Update is called once per frame



    void Update()
    {


        //if (buttonPasserAutorisation == true)
        //{
            //buttonPasser.SetActive(true);

        //}

        if (dialogue > 0)
        {
            //passageDeDialogue();
            dialoguepackage1.SetActive(false);
            
        }
        
        else if (dialogue > 1)
        {
            //passageDeDialogue();
            dialoguepackage2.SetActive(false);

        }

        else if (dialogue > 2)
        {
            //passageDeDialogue();
            dialoguepackage3.SetActive(false);

        }
        
        //_____________________________________________________________
        if (ActiveDialogue1 == true)
        {
            //passageDeDialogue();
            dialoguepackage0.SetActive(true);
        }

        if (ActiveDialogue2 == true)
        {
            //passageDeDialogue();
            dialoguepackage2.SetActive(true);
        }

        if (ActiveDialogue3 == true)
        {
            //passageDeDialogue();
            dialoguepackage3.SetActive(true);
        }

    }
}
