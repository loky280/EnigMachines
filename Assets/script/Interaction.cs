using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    InteractionMachinisteTuto interactionMachinisteTuto;
    public void selectionner() {

        //Debug.Log("test");

    }
    public void Update(){
        
        RaycastHit hit;
        Camera camera = Camera.main;
        if(Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition),out hit)) {
            if (hit.transform.tag == "machiniste1") {
                Debug.Log("machiniste1");
                interactionMachinisteTuto.position = 1;

            }


        }


    }
}
