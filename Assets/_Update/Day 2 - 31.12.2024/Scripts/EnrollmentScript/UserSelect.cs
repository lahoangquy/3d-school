using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UserSelect : MonoBehaviour
{
    public static UserSelect Instance {get;private set;}
    public GameObject Player;
    public bool Uni1,Uni2;//important
    public int CostNeedToPay;
    public bool DArch,DLaw;//important
    bool AddedDArch = false;//check if Cost have been add to DArch
    bool AddedDLaw = false;//check if Cost have been add to DLaw
    public int CostDArch, CostDLaw;
    public bool UniversityHousing, OffCampus;
    public int CostUniversityHousing, CostOffCampus;
    //text for totalcost
    public TMP_Text TotalCostText;
    //status
    public Image DarchStatus;
    public Image DLawStatus;
    //icon
    public Sprite ArchIcon;
    public Sprite LawIcon;
    //Check if Tuition Created
    public bool CreatedArch = false;
    public bool CreatedLaw = false;
    //Line Spacing between Items
    float ItemSpacing=217.9722f;//-0.65f;
    void Start(){
        DontDestroyOnLoad(Player);
    }
    void Awake(){
        if (Instance==null){
            Instance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (DArch && AddedDArch==false){
            CostNeedToPay += CostDArch;
            if (CreatedArch == false){
                TuitionScript.Instance.CreateTuition(ArchIcon, "Architecture Degree - AKA KYS when u grow",250,ItemSpacing);
                CreatedArch = true;
            }
            AddedDArch = true;
        }else if (DLaw && AddedDLaw==false){
            CostNeedToPay += CostDLaw;
            if(CreatedLaw == false){
                TuitionScript.Instance.CreateTuition(LawIcon, "Law Degree - Alright gave him Death Row Already!",150,ItemSpacing-=139.3922f);
                CreatedLaw = true;
            }
            AddedDLaw = true;
        }


        //status
        if (DArch){
            DarchStatus.color = Color.green;
        }else {
            DarchStatus.color = Color.red;
        }

        if (DLaw){
            DLawStatus.color = Color.green;
        }else {
            DLawStatus.color = Color.red;
        }
        TotalCostText.text = CostNeedToPay.ToString();
    }
}
