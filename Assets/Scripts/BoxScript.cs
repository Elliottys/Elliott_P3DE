using UnityEngine;

public class BoxScript : MonoBehaviour
{
	public int Identity;
    public Animator Animator;
	public GameObject IdleBox;
	public GameObject StolenBox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {	
			if (IdleBox.activeSelf)
			{
				PlayerStats script = other.GetComponent<PlayerStats>();
				IdleBox.SetActive(false);
				StolenBox.SetActive(false);
				script.CollectedBoxes[Identity] = true;
				script.UpdateStats();
			}
        }
    }
}
