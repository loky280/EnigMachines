using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalTuto : MonoBehaviour
{
    public DialogueEtTuto dialogueEtTuto;

    [SerializeField]
    GameObject pingEnigmeTuto;

    [SerializeField]
    GameObject pingEnigmeMino;

    [SerializeField]
    GameObject Recompence;

    [SerializeField]
    GameObject okBoutton;

    public enigmeCondition enigmeCondition;

    public void Start()
    {
        Recompence.SetActive(false);
        // if (dialogueEtTuto.disparue == true) { dialogueEtTuto.apparitionDialogue(); }
        pingEnigmeMino.SetActive(false);
    }


    public void Final()
    {

        
        //Debug.Log("test");

        if (enigmeCondition.winPanel1 == true && enigmeCondition.winPanel2 == true && enigmeCondition.winPanel3 == true)
        {
            pingEnigmeTuto.SetActive(false);
            pingEnigmeMino.SetActive(true);
            dialogueEtTuto.dialogue = 13;
            dialogueEtTuto.apparitionDialogue();
            Recompence.SetActive(true);
            okBoutton.SetActive(true);
        }

        else if (dialogueEtTuto.disparue == true && dialogueEtTuto.dialogue == 10) { dialogueEtTuto.apparitionDialogue(); }

    }

    public void OkButton()
    {
        //Debug.Log("test");
        okBoutton.SetActive(false);
        Recompence.SetActive(false);

        }
    


}
