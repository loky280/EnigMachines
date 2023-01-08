using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinDeJeux : MonoBehaviour
{
    public DialogueEtTuto dialogueEtTuto;

    [SerializeField]
    GameObject FinJeux;

    // Start is called before the first frame update
    void Start()
    {
        FinJeux.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogueEtTuto.dialogue == 31)
        {
            FinJeux.SetActive(true);
        }
    }
}
