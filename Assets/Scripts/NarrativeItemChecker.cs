using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NarrativeItemChecker : MonoBehaviour
{

    private float raycastRange = 5.0f;
    private int layerMask = 1 << 8;
    // Update is called once per frame
    void FixedUpdate()
    {
        if (GameManager.instance.player.grabbing)
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, raycastRange, layerMask))
            {
                UIManager.instance.ShowNarrativeText(hit.collider.gameObject.GetComponent<NarrativeItem>());
                Debug.Log("Hiting");
            }
        } 
    }
}
