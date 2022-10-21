using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Random=UnityEngine.Random;

public class RandomPunch : MonoBehaviour 
{   
    public Animator anim;
    public float timeToChangePunch;
    private GameObject whatToCall;
    private float current_time;
    public RuntimeAnimatorController newController;
    GameObject[] allPunch = new GameObject[12];
    private GameObject RightJab;
    private GameObject LeftJab;
    private GameObject JabCrossRight;
    private GameObject JabCrossLeft;
    private GameObject DoubleJabCrossLeft; 
    private GameObject DoubleJabCrossRight; 
    private GameObject JabCrossHookRight;
    private GameObject JabCrossHookLeft; 
    private GameObject HookRight; 
    private GameObject HookLeft;
    private GameObject UppercutRight; 
    private GameObject UppercutLeft;
    void Awake () {
        current_time=timeToChangePunch;
        anim.runtimeAnimatorController = newController;
        RightJab = Resources.Load<GameObject>( "Animations/RightJab");
        LeftJab = Resources.Load<GameObject>( "Animations/LeftJab");
        JabCrossRight = Resources.Load<GameObject>( "Animations/JabCrossRight");
        JabCrossLeft = Resources.Load<GameObject>( "Animations/JabCrossLeft");
        DoubleJabCrossLeft = Resources.Load<GameObject>( "Animations/DoubleJabCrossLeft");
        DoubleJabCrossRight = Resources.Load<GameObject>( "Animations/DoubleJabCrossRight");
        JabCrossHookRight = Resources.Load<GameObject>( "Animations/JabCrossHookRight");
        JabCrossHookLeft = Resources.Load<GameObject>( "Animations/JabCrossHookLeft");
        HookRight = Resources.Load<GameObject>( "Animations/HookRight");
        HookLeft = Resources.Load<GameObject>( "Animations/HookLeft");
        UppercutRight = Resources.Load<GameObject>( "Animations/UppercutRight");
        UppercutLeft = Resources.Load<GameObject>( "Animations/UppercutLeft");
    }
    
     // Use this for initialization
    void Start () {
        allPunch[0]=RightJab ;
        allPunch[1]=LeftJab;
        allPunch[2]=JabCrossRight;
        allPunch[3]=JabCrossLeft;
        allPunch[4]=DoubleJabCrossLeft;
        allPunch[5]=DoubleJabCrossRight;
        allPunch[6]=JabCrossHookRight;
        allPunch[7]=JabCrossHookLeft;
        allPunch[8]=HookRight;
        allPunch[9]=HookLeft;
        allPunch[10]=UppercutRight;
        allPunch[11]=UppercutLeft;
        ChangePunch();
    }
     
     // Update is called once per frame
    void Update () {
         current_time -= Time.deltaTime;
 
         if (current_time <= 0) {
             ChangePunch();
        }
        else {
             anim.SetBool("DoUppercutLeft",false);
            anim.SetBool("DoUppercutRight",false);
            anim.SetBool("DoRightJab",false);
            anim.SetBool("DoLeftJab",false);
            anim.SetBool("DoJabCrossRight",false);
            anim.SetBool("DoJabCrossLeft",false);
            anim.SetBool("DoDoubleJabCrossRight",false);
            anim.SetBool("DoDoubleJabCrossLeft",false);
            anim.SetBool("DoJabCrossHookRight",false);
            anim.SetBool("DoJabCrossHookLeft",false);
            anim.SetBool("DoHookRight",false);
            anim.SetBool("DoHookLeft",false);
        }
 
    }
 
    void ChangePunch() {
        int whichPunch = Random.Range(0, allPunch.Length);
        whatToCall = allPunch[whichPunch];
        anim.SetBool("DoUppercutLeft",false);
        anim.SetBool("DoUppercutRight",false);
        anim.SetBool("DoRightJab",false);
        anim.SetBool("DoLeftJab",false);
        anim.SetBool("DoJabCrossRight",false);
        anim.SetBool("DoJabCrossLeft",false);
        anim.SetBool("DoDoubleJabCrossRight",false);
        anim.SetBool("DoDoubleJabCrossLeft",false);
        anim.SetBool("DoJabCrossHookRight",false);
        anim.SetBool("DoJabCrossHookLeft",false);
        anim.SetBool("DoHookRight",false);
        anim.SetBool("DoHookLeft",false);
        if (whatToCall==UppercutLeft) {
            anim.SetBool("DoUppercutLeft",true);
        }
        if (whatToCall==UppercutRight) {
            anim.SetBool("DoUppercutRight",true);
        }
        if (whatToCall==RightJab) {
            anim.SetBool("DoRightJab",true);
        }
        if (whatToCall==LeftJab) {
            anim.SetBool("DoLeftJab",true);
        }
        if (whatToCall==JabCrossRight) {
            anim.SetBool("DoJabCrossRight",true);
        }
        if (whatToCall==JabCrossLeft) {
            anim.SetBool("DoJabCrossLeft",true);
        }
        if (whatToCall==JabCrossHookLeft) {
            anim.SetBool("DoJabCrossHookLeft",true);
        }
        if (whatToCall==JabCrossHookRight) {
            anim.SetBool("DoJabCrossHookRight",true);
        }
        if (whatToCall==DoubleJabCrossLeft) {
            anim.SetBool("DoDoubleJabCrossLeft",true);
        }
        if (whatToCall==DoubleJabCrossRight) {
            anim.SetBool("DoDoubleJabCrossRight",true);
        }
        if (whatToCall==HookLeft) {
            anim.SetBool("DoHookLeft",true);
        }
        if (whatToCall==HookRight) {
            anim.SetBool("DoHookRight",true);
        }
        current_time = timeToChangePunch;
    }
}
    

