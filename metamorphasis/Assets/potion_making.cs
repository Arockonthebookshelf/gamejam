using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class potion_making : MonoBehaviour
{
   
    public static GameObject potion;
    private void Awake()
    {
        potion.SetActive(false);
    }
}
