using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinRegion : MonoBehaviour
{	
	// hard coding EVERYTHING because i cant be bothered anymore and i don't have time at this point
	public GameObject box1;
	public GameObject box2;
	public GameObject box3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {	
			PlayerStats script = other.GetComponent<PlayerStats>();
			if (script.CollectedBoxes[0])
			{
				script.CollectedBoxes[0] = false;
				script.StolenBoxes[0] = true;
				box1.SetActive(true);
				box1.GetComponent<Animator>().Play("opening_anim");
			}
			if (script.CollectedBoxes[1])
			{
				script.CollectedBoxes[1] = false;
				script.StolenBoxes[1] = true;
				box2.SetActive(true);
				box2.GetComponent<Animator>().Play("opening_anim");
			}
			if (script.CollectedBoxes[2])
			{
				script.CollectedBoxes[2] = false;
				script.StolenBoxes[2] = true;
				box3.SetActive(true);
				box3.GetComponent<Animator>().Play("opening_anim");
			}
			script.UpdateStats();
        }
    }
}
