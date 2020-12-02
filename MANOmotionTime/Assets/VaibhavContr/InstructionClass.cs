using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructionClass : MonoBehaviour
{
    public GameObject[] instructionsPopUps;
    private int instructionsindex;
  //  public bool PlaneScannedflag;
  //  public bool BeaconPlacedflag;
  //  public bool HandsScanned;
    public InstructionState currentstate;
    public enum InstructionState
    {
        ScanPlane,
        PlaceBeacon,
        BeaconPlaced,
        ScanHands
    }
    // Start is called before the first frame update
    void Start()
    {
        currentstate = InstructionState.ScanPlane;
        instructionsindex = 0;
        InstructionSetter(instructionsindex);

    }

    void InstructionSetter(int instructionindex)
    {
        for(int i=0;i<instructionsPopUps.Length;i++)
        {
            if(i==instructionsindex)
            {
                instructionsPopUps[i].SetActive(true);
            }
            else
            {
                instructionsPopUps[i].SetActive(false);
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        instructionsindex = (int)currentstate;
        InstructionSetter(instructionsindex);
         
    }
}
