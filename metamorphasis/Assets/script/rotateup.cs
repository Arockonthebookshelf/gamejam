using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    Sprite Sr;
    NPC npc;
    void Start()
    {
        Sr = GetComponent<Sprite>();
        npc = GameObject.FindGameObjectWithTag("NPC").AddComponent<NPC>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
