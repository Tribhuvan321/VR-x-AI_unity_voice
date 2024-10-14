using UnityEngine;
using Meta.WitAi;
using Oculus.Voice;
using Meta.WitAi.Configuration;

public class VoiceController : MonoBehaviour
{
    [SerializeField] private AppVoiceExperience wit;

    void Start()
    {
        /*// Find the Wit component attached to the WitObject
        wit = GameObject.Find("App Voice Experience").GetComponent<WitService>();
        

        if (wit == null)
        {
            Debug.LogError("Wit component not found!");
        }*/

        wit = GameObject.Find("App Voice Experience").GetComponent<AppVoiceExperience>();
        //wit.Activate();

        if(wit == null)
        {
            Debug.LogError("Wit component not found!");
        }
    }

    void Update()
    {
        // Call Activate method when a key is pressed (e.g., space bar)
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger, OVRInput.Controller.RTouch))
        {
            ActivateVoice();
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            ActivateVoice();
        }
    }

    public void ActivateVoice()
    {
        if (wit != null)
        {
            wit.Activate();
            Debug.Log("Wit activated!");
        }
    }
}
