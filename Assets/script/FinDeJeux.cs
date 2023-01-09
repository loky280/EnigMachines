using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FinDeJeux : MonoBehaviour
{
    public DialogueEtTuto dialogueEtTuto;

    [SerializeField]
    GameObject FinJeux;
    
    public bool stop;

    // Start is called before the first frame update
    void Start()
    {
        stop = false;
        FinJeux.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueEtTuto.dialogue == 31 && stop == false )
        {
            stop = true;
            FinJeux.SetActive(true);
        }
    }
}
