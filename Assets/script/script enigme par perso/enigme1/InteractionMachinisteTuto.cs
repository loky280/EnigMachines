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
    public int position = 0;

    //position_interface => X = 24.20001/ Y = 6.9     /   Z = -3.9

    //position_interface_Hors_Cam =>  X = 24.20001  / Y = 6.9    /   Z = 36.1

    //Vector => X = 0   /  Y =0   /   Z = -40

    // cam =>  X= 0   Y=12.1     Z=-10
  /*
    public void Button_Interaction_Machiniste1()

    {
        
        Debug.Log("test");
        position = 1;
        //panel.transform.Translate(24.20001,6.9,-3.9);
        //panel.transform.Translate(24, 7, -4);
        //panel.transform.Translate(xTransform, yTransform, zTransform);
    }
    */
    void Update()
    {

        panel.transform.Translate(xTransform, yTransform, zTransform);

        //position de base
        if (position == 0)
        {
            xTransform = 0;
            yTransform = 0;
            zTransform = 0;

        }

        //aller dans le champ
        else if (position == 1)
        {
            xTransform = 0;
            yTransform = 0;
            zTransform = -40;
        }


        //aller a droite
        else if (position == 2)
        {
            xTransform = 10;
            yTransform = 0;
            zTransform = 0;

        }

        //aller a gauche
        else if (position == 3)
        {
            xTransform = -10;
            yTransform = 0;
            zTransform = 0;

        }

        //aller hors champ
        else if (position == 4)
        {
            xTransform = 0;
            yTransform = 0;
            zTransform = 40;

        }

    }
}
