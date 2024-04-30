using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeScript : MonoBehaviour
{
	public Animator Animator;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {	
            Animator.Play("drinking_anim");
        }
    }
}
