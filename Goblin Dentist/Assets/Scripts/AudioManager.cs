using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : SingletonBase<AudioManager>
{
    protected AudioManager() { }
    private AudioSource SFX;
    private List<AudioClip> clips;
    private List<string> clipNames;
    private GameObject audioManager;

    private void Start()
    {
        audioManager = gameObject;
        SFX = audioManager.GetComponent<AudioSource>();
    }


    public void toolPickup()
    {
        clipNames = new List<string>
        {
            "Tool_Grab1_Household Blanket Grab And Pull 01",
            "Tool_Grab2_Household Blanket Grab And Pull 01",
            "Tool_Grab3_Household Blanket Grab And Pull 01",
            "Tool_Grab4_Household Blanket Grab And Pull 01"
        };
        int num = Random.Range(0, clipNames.Count-1);
        AudioClip clip = Resources.Load<AudioClip>(string.Format("SoundAssets/" + clipNames[num]));
        SFX.PlayOneShot(clip);
        
    }
    public void toothRepair()
    {


        switch (ToolManager.Instance.getrepairType().ToString())
        {
            case "Healthy":
                clipNames = new List<string>
                {
                    "G1_Pain1",
                    "G4_Pain1",
                    "G1_Pain2",
                    "G1_Pain2",
                    "G4_Pain2"
                };
                break;

            case "Metal":
                clipNames = new List<string>
                {
                    "Cement_Tube_ Horror Scary Eyeball Squeeze Squish",
                    "Dentist Drill-Mike_Koenig-573483666",
                    "Cement_Tube_Squishy 2-Mike_Koenig-1775292371",
                    "Cement_Tube_Spit_Splat-Mike_Koenig-1170500447",
                    "Cement_Tube_Squish 1-Mike_Koenig-662226724"
                };
                break;

            case "Gold":
                clipNames = null;
                break;

            case "Missing":
                clipNames = null;
                break;

            case "Wooden":
                clipNames = new List<string>
                {
                    "Hammer - Impact Object Dropped Ground Dull Thud 06",
                    "Hammer - Impact Punch Hard Single 01",
                    "Hammer - Impact Punch Wet Punch 01",
                    "Hammer - Impact Punch Wet Punch 01",
                    "Hammer - Impact Punch Wet Punch 01"
                };
                break;

            default:
                clipNames = null;
                break;
        }

       
        if(clipNames != null) {
            int num = Random.Range(0, clipNames.Count - 1);
            AudioClip clip = Resources.Load<AudioClip>(string.Format("SoundAssets/" + clipNames[num]));
            SFX.PlayOneShot(clip);
        }
        clipNames = new List<string>
        {
            "G1_Pain1",
            "G4_Pain1",
            "G1_Pain2",
            "G1_Pain2",
            "G4_Pain2",
            "G1_Ack"
        };

    }
}