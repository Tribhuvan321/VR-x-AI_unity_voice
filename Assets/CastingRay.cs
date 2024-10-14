using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Meta.WitAi; // Ensure you have the correct namespace
using static Meta.WitAi.VoiceService; // Namespace for Voice Service

public class CastingRay : MonoBehaviour
{
    public GameObject spawnPoint;
    public GameObject flag;
    public float force;
    public RaycastHit hitInfo;

    void Start()
    {

    }

    void Update()
    {
        bool rayData = Physics.Raycast(spawnPoint.transform.position, spawnPoint.transform.up, out hitInfo, 10f);
        if (rayData && hitInfo.transform != null && hitInfo.transform.name == "Object")
        {
            Debug.Log(hitInfo.transform.name);
            flag.SetActive(true);
        }
        else
        {
            flag.SetActive(false);
        }
    }

    public void Push(string[] values)
    {
        if (flag.activeSelf && (values[0] == "flipendo" || values[0] == "Flipendo" || values[0] == "Fire" || values[0] == "fire"))
        {
            Rigidbody rb = this.gameObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddForce(this.transform.forward * force, ForceMode.Impulse);
            }
            else
            {
                Debug.LogError("Rigidbody component not found!");
            }
        }
    }
}
