using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Script ment to handle the game systems of the game.
/// </summary>
public class MasterManager : MonoBehaviour
{
    public static MasterManager masterManager;

    public CharacterBase characterBasePrefab;

    private void Awake()
    {
        masterManager = this;
    }

    void Start()
    {
        
    }

    //Function to run all the initial steps of the game. Such as instantiating the character/s
    public void Init()
    {
        GameObject go = Instantiate(characterBasePrefab.gameObject);
    }
}
