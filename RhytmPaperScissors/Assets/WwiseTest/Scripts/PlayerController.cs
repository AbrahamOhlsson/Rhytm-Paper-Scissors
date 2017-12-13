using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;


    // Use this for initialization
    void Start()
    {
        AkSoundEngine.PostEvent("StartMusic", gameObject);
        // AkSoundEngine.SetState("PlayerLife", "Alive");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0f, 0f));
            AkSoundEngine.SetState("PlayerLife", "Alive");


        }

        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            transform.Translate(new Vector3(0f, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0f));
            AkSoundEngine.SetState("PlayerLife", "Dead");

        }

    }


    void Beat(AkEventCallbackMsg in_info)
    {
        // AkSoundEngine.PostEvent("StartMusic", gameObject);
        //AkSoundEngine.GetPlayingSegmentInfo("StartMusic", );
    }


    // ..........Unity CRASHED from this was a desperate attempt at reaching the SegmentInfo...........

    //void MusicCallback(AkCallbackType AK_MusicSyncBeat, AkCallbackInfo AkMusicSyncCallbackInfo)
    //{
    //    fBeat = AkSoundEnginePINVOKE.CSharp_AkMusicSyncCallbackInfo_segmentInfo_fBeatDuration_get(swigCPtr);

    //    float realBPM = 60 / fBeat;
    //    Debug.Log("The current realBPM is: " + realBPM);

    //}
}
