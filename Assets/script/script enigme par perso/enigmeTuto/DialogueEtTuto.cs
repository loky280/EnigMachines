using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueEtTuto : MonoBehaviour
{
    public bool FinDialogue;

    public bool debutDialogue;
    //public bool ActiveDialogue1;

    //public bool ActiveDialogue2;

    //public bool ActiveDialogue3;

    //public bool buttonPasserAutorisation;

    [SerializeField]
    GameObject buttonPasser;

    [SerializeField]
    GameObject dialogueUI;
    /*
    [SerializeField]
    GameObject dialoguepackage0;

    [SerializeField]
    GameObject dialoguepackage1;
    
    [SerializeField]
    GameObject dialoguepackage2;
    
    [SerializeField]
    GameObject dialoguepackage3;
    */

    [SerializeField]
    GameObject[] dialoguepackage;

    public int dialogue;
    public int dialogueMoinUn;


    // Start is called before the first frame update
    void Start()
    {
        //debutDialogue = false;
        //FinDialogue = false;
        dialogueMoinUn = 0;
        dialogue = 0;
        //buttonPasser.SetActive(false);
        //dialogueUI.SetActive(false);
        //dialoguepackage[0].SetActive(false);

        disparitionDialogue();
        dialoguepackage[0].SetActive(false);
        dialoguepackage[1].SetActive(false);
        dialoguepackage[2].SetActive(false);
        dialoguepackage[3].SetActive(false);
        dialoguepackage[4].SetActive(false);
        dialoguepackage[5].SetActive(false);
        
        dialoguepackage[6].SetActive(false);
        dialoguepackage[7].SetActive(false);
        dialoguepackage[8].SetActive(false);
        dialoguepackage[9].SetActive(false);
        dialoguepackage[10].SetActive(false);
        dialoguepackage[11].SetActive(false);
        
        dialoguepackage[12].SetActive(false);
        dialoguepackage[13].SetActive(false);
        dialoguepackage[14].SetActive(false);
        dialoguepackage[15].SetActive(false);
        //dialoguepackage1.SetActive(true);

        //buttonPasserAutorisation = true;
        //ActiveDialogue1 = false;
        //ActiveDialogue3 = false;
        //ActiveDialogue2 = false;
        //dialoguepackage0.SetActive(false);
        //dialoguepackage1.SetActive(false);
        //dialoguepackage2.SetActive(false);
        //dialoguepackage3.SetActive(false);
    }




    public void passageDeDialogueButton()
    {
        //dialogue précédent
        dialogueMoinUn = dialogue;
        
        //dialogue suivant
        dialogue += 1;

        if (dialogue <15)
        {
            //_______________________changement de dialogue precedent avec le suivant
            dialoguepackage[dialogueMoinUn].SetActive(false);
            dialoguepackage[dialogue].SetActive(true);
        
           
        }
        
        //___________________________________________condition de disparition des dialogue
        if (dialogue == 5)
        {
            disparitionDialogue();
        }

        if (dialogue == 15)
        {
            disparitionDialogue();
        }

        /*
        else if (debutDialogue == true)
        {
            apparitionDialogue();
        }
        */




    }

    public void disparitionDialogue()
    {
        buttonPasser.SetActive(false);
        dialogueUI.SetActive(false);
        dialoguepackage[dialogue].SetActive(false);
    }


    public void apparitionDialogue()
    {
        buttonPasser.SetActive(true);
        dialogueUI.SetActive(true);
        dialoguepackage[dialogue].SetActive(true);
    }
    //public void passageDeDialogue (){

    //dialoguepackage1.SetActive(false);
    //}
    // Update is called once per frame



    void Update()
    {
        /*
        if (dialogue == 3)
        {
            disparitionDialogue();
        }
        */

        //if (buttonPasserAutorisation == true)
        //{
        //buttonPasser.SetActive(true);

        //}
        //if dialogue =
        //dialoguepackage[dialogue].SetActive(true);



        /*
        if (dialogue == 0)
        {
            //passageDeDialogue();
            dialoguepackage[0].SetActive(true);
            
        }
        
        else if (dialogue == 1)
        {
            //passageDeDialogue();
            dialoguepackage[1].SetActive(true);

        }

        else if (dialogue == 2)
        {
            //passageDeDialogue();
            dialoguepackage[2].SetActive(true);

        }


        else if (dialogue == 3)
        {
            //passageDeDialogue();
            dialoguepackage[3].SetActive(true);

        }
        
        else if (dialogue == 4)
        {
            //passageDeDialogue();
            dialoguepackage[4].SetActive(true);

        }

        else if (dialogue == 5)
        {
            //passageDeDialogue();
            dialoguepackage[5].SetActive(true);

        }
        */
        /*
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
        */
    }
}
