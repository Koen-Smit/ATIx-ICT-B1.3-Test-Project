using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TMP_Text choiceText;
    public TMP_Text computerChoiceText;
    public TMP_Text winnerText;

    private string playerChoice = "";
    private string computerChoice = "";

    public void SetPlayerChoice(string choice)
    {
        playerChoice = choice;
        choiceText.text = "Keuze: " + playerChoice;
        SetComputerChoice();
    }

    public void SetComputerChoice()
    {
        string[] choices = { "rock", "paper", "scissors" };
        computerChoice = choices[Random.Range(0, choices.Length)];
        computerChoiceText.text = "Computer keuze: " + computerChoice;
        DetermineWinner();
    }

    public void DetermineWinner()
    {
        string resultMessage = "";

        if (playerChoice == computerChoice)
        {
            resultMessage = "Gelijkspel!"; // Tie
        }
        else if ((playerChoice == "rock" && computerChoice == "scissors") ||
                 (playerChoice == "paper" && computerChoice == "rock") ||
                 (playerChoice == "scissors" && computerChoice == "paper"))
        {
            resultMessage = "Jij wint!"; // Player wins
        }        
        else
        {
            resultMessage = "Computer wint!"; // Computer wins
        }

        winnerText.text = "Winnaar: " + resultMessage; // Update UI 
    }
}
