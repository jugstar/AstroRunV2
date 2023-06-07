using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KeyTutorial : Tutorial
{
    public List<string> Keys = new List<string>(); // these are they you need to press

    public override void CheckIfHappening()
    {
        for (int i = 0; i < Keys.Count; i++)
        {
            if (Input.inputString.Contains(Keys[i]))
            {
                Keys.RemoveAt(i);
                break;
            }
        }
        if (Keys.Count == 0)
            TutorialManager.Instace.CompletedTutorial();
    }

    
}
