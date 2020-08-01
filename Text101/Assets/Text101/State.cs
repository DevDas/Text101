using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class State : ScriptableObject
{
   [TextArea(14,10)] [SerializeField] string StoryText;

    public string GetStateStory()
    {
        return StoryText;
    }
}
