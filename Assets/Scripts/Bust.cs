﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRM;

public class Bust : MonoBehaviour
{
    public GameObject gameObj;
    VRMBlendShapeProxy proxy;
    // Start is called before the first frame update
    void Start()
    {
        proxy = gameObj.GetComponent<VRMBlendShapeProxy>();
        // proxy.ImmediatelySetValue(BlendShapePreset.Angry, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //HandTagを追加したコントローラーを、タグを判別し振動
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Hand")
        {
            proxy.ImmediatelySetValue(BlendShapePreset.Angry, 1.0f);  //表情の変化 第一引数 BlendShapePreset key(表情の種類) 第二引数表情変化
            // proxy.ImmediatelySetValue("ANGRY", 1);

            OVRInput.SetControllerVibration(0.3f, 0.3f, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(0.3f, 0.3f, OVRInput.Controller.LTouch);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Hand")
        {
            proxy.ImmediatelySetValue(BlendShapePreset.Angry, 0);  //表情の変化
            // proxy.ImmediatelySetValue("ANGRY", 0);

            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
        }
    }
}