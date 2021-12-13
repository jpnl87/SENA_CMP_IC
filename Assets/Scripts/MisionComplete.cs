using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class MisionComplete : MonoBehaviour
{
    public NPCConversation myconversation;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void startconversation()
    {
        ConversationManager.Instance.StartConversation(myconversation);
    }
  
}
