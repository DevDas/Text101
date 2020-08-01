using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text TextComponent;
    [SerializeField] State StartingState;

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
        
    }
}
