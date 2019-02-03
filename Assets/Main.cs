using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effect
{
}

public class Card
{
    public Color color { get; set; }
    public int manaCost { get; set; }
    public List<Effect> aura { get; }
    public List<Effect> turnStart { get; set; }
    public List<Effect> turnEnd { get; set; }
    public List<Effect> battleCry { get; set; }
    public List<Effect> deathRattle { get; set; }
}

public class Unit : Card
{
    public int power { get; set; }
    public int health { get; set; }
}

public class Hero : Card
{
    public int power { get; set; }
    public int health { get; set; }
    public bool active { get; set; }
}


public class Board
{
    List<List<GameObject>> board;
    Board()
    {
        //Build Blank Board
    }
}

public class Player
{
    public int health { get; set; }
    public int maxMana { get; set; }
    public int currMana { get; set; }
    public List<Card> Deck { get; set; }
    public List<Card> Hand { get; set; }
    public List<Hero> heroDeck { get; set; }
}

public class AIPlayer : Player
{
    public string logic { get; set; }
}

public class Game : MonoBehaviour
{
    Player P1;
    Player P2;
    Player currentPlayer; //P0, P1
    Board gameBoard;

    // Start is called before the first frame update
    void Start()
    {
        //Gamestart
        //Init Board
        //Init Players
        //Each Player Draws 6 cards
        //Mulligan
    }

    // Update is called once per frame
    void Update()
    {
        //read player input
        // check if click
        //
    }

    playerAction Turn(Player currPlayer)
    {
        //Action
        //Change Player
        return playerAction.Pass;
    }
    void Round()
    {
        playerAction p1_action = playerAction.noAction;
        playerAction p2_action = playerAction.noAction;
        //Check Ready Heroes
        //Mana refresh
        //Players Draw
        //Start of Round Effects
        // While not Pass:
        //      P1 Turn
        //      P2 Turn
        //End of Round effects trigger
    }
}

public enum playerAction { noAction, Summon, Attack, Pass, Move }
public enum Color { }