using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.Rendering.DebugUI;
using UnityEngine.UIElements;

public class buttonAllerADroite : MonoBehaviour
{
    // Start is called before the first frame update
    InteractionMachinisteTuto interactionMachinisteTuto;
    public void Button_Interaction_AllerADroite()

    {

        //Debug.Log("Machiniste1");
        interactionMachinisteTuto.position = 1;
       
    }
}
