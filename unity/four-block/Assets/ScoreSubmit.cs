using System.Collections;
using System.Collections.Generic;
using game.logic.EventQueue;
using network.score;
using network.user;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScoreSubmit : MonoBehaviour
{
    [SerializeField] private TMP_InputField _inputField;

    /// <summary>
    /// Initializes the application or component.
    /// </summary>
    /// <remarks>
    /// This method is typically called when the application starts or when the component is instantiated.
    /// It is used to set up any necessary resources, initialize variables, or perform any startup tasks
    /// required for the application to function correctly.
    /// This method does not return any value and does not take any parameters.
    /// </remarks>
    void Start()
    {
        
    }

    /// <summary>
    /// Updates the state of the object.
    /// </summary>
    /// <remarks>
    /// This method is intended to be called to refresh or update the internal state of the object.
    /// It may be used to perform operations such as refreshing data, recalculating values, or applying changes.
    /// The specific implementation details and effects of this method depend on the context in which it is used.
    /// As it currently stands, this method does not perform any operations, but it can be overridden in derived classes to provide specific functionality.
    /// </remarks>
    void Update()
    {
        
    }

    /// <summary>
    /// Submits the player's score to the score service.
    /// </summary>
    /// <remarks>
    /// This method retrieves the score from the input field, parses it as an integer, and then submits it to the ScoreService for processing.
    /// It assumes that the input field contains a valid integer representation of the score.
    /// If the input is not a valid integer, a format exception may occur during parsing.
    /// This method does not return any value, as it is intended to perform an action (submitting the score) rather than compute a result.
    /// </remarks>
    public void Win()
    {
        var score = int.Parse(_inputField.text);
        ScoreService scoreService = new ScoreService();
        scoreService.SubmitScore(score);
    }
}
