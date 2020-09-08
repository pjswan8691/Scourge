using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public void Init()
    {
        GameObject go = Instantiate(characterBasePrefab.gameObject);
    }
}
