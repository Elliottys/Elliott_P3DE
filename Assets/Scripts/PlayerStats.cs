using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
	public TMP_Text TextUI;
    public bool[] CollectedBoxes = {false, false, false};
    public bool[] StolenBoxes = {false, false, false};
	
	public void UpdateStats()
	{
		int CollectedCount = CountTrueBooleans(CollectedBoxes);
        int StolenCount = CountTrueBooleans(StolenBoxes);
		
		TextUI.text = "Carrying " + CollectedCount + " boxes\nStolen " + StolenCount + " boxes";
	}
	
	private int CountTrueBooleans(bool[] array)
    {
        int count = 0;
        foreach (bool value in array)
        {
            if (value)
			{
                count++;
			}
        }
        return count;
    }
}
