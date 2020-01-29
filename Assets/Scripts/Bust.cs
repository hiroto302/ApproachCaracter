using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bust : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
            OVRInput.SetControllerVibration(0.3f, 0.3f, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(0.3f, 0.3f, OVRInput.Controller.LTouch);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.tag == "Hand")
        {
            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.RTouch);
            OVRInput.SetControllerVibration(0, 0, OVRInput.Controller.LTouch);
        }
    }
}
