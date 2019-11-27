using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State starting_state;

    State state;
    void Start()
    {        
        state = starting_state;
        textComponent.text = state.GetStoryText();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
