using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBattle : MonoBehaviour
{
    private Animator characterBase;
    private void Start()
    {
        characterBase = GetComponent<Animator>();
        Run();
    }
    //Test animation
    private void Run()
    {
        characterBase.SetBool("Bool_Move", true);
    }
}
