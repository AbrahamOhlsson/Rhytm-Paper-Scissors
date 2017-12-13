
//#include <AK/SoundEngine/Common/AkCommonDefs.h>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PrintCallbacks : MonoBehaviour
{

    int BarCounter = 0;
    int BeatCounter = 0;
    float StartTime;
    float t = 0;
    float BPM = 0;



    // Use this for initialization
    void Start()
    {
        StartTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {


    }

    // Receives callbacks from Wwise every bar. Restarts the clock and BeatCounter. Attempts to calculate the BPM.
    void CallbackBar(AkEventCallbackMsg in_info)
    {
        BarCounter++;
        BeatCounter = 0;
        t = Time.time - StartTime;
        BPM = 60 / t;
        StartTime = Time.time;

        Debug.Log("The current bar is: " + BarCounter);
        Debug.Log("The current BPM is: " + BPM);
    }

    // Receives callbacks from Wwise every beat. Restarts the clock and adds to the BeatCounter. Attempts to calculate the BPM.
    void CallbackBeat(AkEventCallbackMsg in_info)
    {
        BeatCounter++;
        Debug.Log(BeatCounter);

        if (BeatCounter == 1)
        {
            return;
        }

        else
        {
            t = Time.time - StartTime;
            BPM = 60 / t;
            StartTime = Time.time;

            Debug.Log("The current BPM is: " + BPM);
        }


        /*
        AkSegmentInfo info = null;

        ulong id = AkSoundEngine.GetAkGameObjectID(PlayerGO);
        AKRESULT result = AkSoundEngine.GetPlayingSegmentInfo((uint)PlayerGO.GetInstanceID(), info, true);

        print(result);
        */



        //string minutes = ((int)t / 60).ToString();
        //string seconds = (t % 60).ToString();

        //Debug.Log("The length of a beat is: " + t + " seconds");
    }

    // ..............This made Unity CRASH...............

    //void MusicCallback(AkCallbackType AK_MusicSyncBeat, AkCallbackInfo AkMusicSyncCallbackInfo)
    //{
    //    fBeat = AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get();

    //    float realBPM = 60 / fBeat;
    //    Debug.Log("The current realBPM is: " + BPM);

    //}




}

