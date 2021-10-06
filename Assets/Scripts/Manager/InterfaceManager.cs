using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField]
    private Button joinPlayerOne;

    //TODO: Add PlayerTwoButton reference DONE
    [SerializeField]
    private Button joinPlayerTwo;

    [SerializeField]
    private Text textOne;

    [SerializeField]
    private Text textTwo;

    [SerializeField]
    private GameObject objOne;

    [SerializeField]
    private GameObject objTwo;

    [SerializeField]
    private SplitKeyboardPlayerInputManager playerInputManager;
    // Start is called before the first frame update
    void Start()
    {
        joinPlayerOne.onClick.AddListener(() => JoinPlayerOne());
        //TODO Listen for player two click event DONE
        joinPlayerTwo.onClick.AddListener(() => JoinPlayerTwo());
    }

    private void JoinPlayerOne()
    {
        playerInputManager.JoinPlayer(0, "Keyboard&Mouse");

        //TODO on click after player has joined, remove player DONE
        if (string.Equals(textOne.text, "Leave Player One"))
        {
            playerInputManager.LeavePlayer(0);
        }

        //TODO flip text to say "Leave Player One" DONE
        textOne.text = "Leave Player One";

    }

    private void JoinPlayerTwo()
    {
        //TODO Invoke JoinPlayer passing a playerIndex value and targeting a control scheme DONE
        playerInputManager.JoinPlayer(1, "PlayerTwo");

        //TODO on click after player has joined, remove player DONE
        if (string.Equals(textTwo.text, "Leave Player Two"))
        {
            playerInputManager.LeavePlayer(1);
        }

        //TODO flip text after player has joined to say "Leave Player Two" DONE
        textTwo.text = "Leave Player Two";

    }
}
