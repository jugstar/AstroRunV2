using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    // Every tutorial needs these two variables
    public int Order; // order of the tutorials

    [TextArea(3,10)]
    public string Explanation; // Text that instructs the player
    

    void Awake()
    {
        // Returns an instance tutorials in the scene from TutorialManager
        TutorialManager.Instace.Tutorials.Add(this);
    }
    
    public virtual void CheckIfHappening() { }
}
