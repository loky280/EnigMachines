using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionMachinisteTuto : MonoBehaviour
{
    // Variables
    [SerializeField]
    GameObject panel;

    public float xTransform;
    public float yTransform;
    public float zTransform;

    //position_interface => X = 1.370746  / Y = -23.02849     /   Z = 37.24416

    //position_interface_Hors_Cam =>  X = 1.370746  / Y = -42.6     /   Z = 71.4

    //Vector => X = 0   /  Y = -19,57151   /   Z = 34,15584

    public void Button_Interaction_Machiniste1()

    {
        Debug.Log("Machiniste1");
        panel.transform.Translate(0,19,-34);
    }
}
