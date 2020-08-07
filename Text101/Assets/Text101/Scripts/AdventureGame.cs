using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text TextComponent; // Set 'Story Text' In The Editor
    [SerializeField] State StartingState; // Set 'StartingText' In The Editor

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = StartingState;
        TextComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {  
        var NextStates = state.GetNextStates();

        for (int i = 0; i < NextStates.Length; i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            { 
                state = NextStates[i];
            }
        }

        TextComponent.text = state.GetStateStory();
    }
}