using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10,14)] [SerializeField] string story_text;

    [SerializeField] State[] next_state;

    public string GetStoryText() {
        
        return story_text;
    }

    public State[] GetNextStates() {

        return next_state;
    }
    
}
