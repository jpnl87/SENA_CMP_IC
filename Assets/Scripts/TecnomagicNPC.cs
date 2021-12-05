using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class TecnomagicNPC : MonoBehaviour
{
    public NPCConversation myconversation;

    private void OnMouseOver()
    {
        {
            if(Input.GetMouseButtonDown(0))
            {
                ConversationManager.Instance.StartConversation(myconversation);
            }
        }
    }
}
