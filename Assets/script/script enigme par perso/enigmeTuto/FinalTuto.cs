using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTuto : MonoBehaviour
{
    public DialogueEtTuto dialogueEtTuto;

    [SerializeField]
    GameObject Recompence;

    [SerializeField]
    GameObject okBoutton;

    public enigmeCondition enigmeCondition;

    public void Start()
    {
        Recompence.SetActive(false);
       // if (dialogueEtTuto.disparue == true) { dialogueEtTuto.apparitionDialogue(); }

    }


    public void Final()
    {
        if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 10) { dialogueEtTuto.apparitionDialogue(); }
        //Debug.Log("test");

        if (enigmeCondition.winPanel1 == true && enigmeCondition.winPanel2 == true && enigmeCondition.winPanel3 == true)
        {
            
            dialogueEtTuto.dialogue = 13;
            dialogueEtTuto.apparitionDialogue();
            Recompence.SetActive(true);
            okBoutton.SetActive(true);
        }
    }

    public void OkButton()
    {
        //Debug.Log("test");
        okBoutton.SetActive(false);
        Recompence.SetActive(false);

        }
    


}
