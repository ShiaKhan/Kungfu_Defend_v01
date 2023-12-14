using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BattleHandle : MonoBehaviour
{
    [SerializeField] private Transform pfCharacter_01;
    [SerializeField] private Transform pfEnemy_01;

    private void Start(){
        SpawnCharacter(true);
        SpawnCharacter(false);
    }

    private void SpawnCharacter(bool isCharacter)
    {
        Vector3 position;
        if(isCharacter)
        {
            position = new Vector3(-5, 0);
            Instantiate(pfCharacter_01, position, Quaternion.identity);
            Debug.Log("Character create");
        }else{
            position = new Vector3( 5, 0);
            Instantiate(pfEnemy_01, position, Quaternion.identity);
            Debug.Log("Enemy has create");
        }
        
    }
}
