using System.Collections;
using System.Collections.Generic;
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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = NextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = NextStates[1];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            state = NextStates[2];
        }
        TextComponent.text = state.GetStateStory();
    }
}
