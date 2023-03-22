using System;
using Godot;
using System.Collections;

public class Global_Data:Node
{
    
    public string currentPlayingType = "";
    public Dice rolledDice = null;
    public bool isPieceTransioning = false;
    public Godot.Collections.Array boardRects;
    public Godot.Collections.Array allRects;
    public Basic_Piece targetPiece = null;
    public ArrayList testingPieces = new ArrayList();
    public Basic_Board ludoBoard = null;
    public Player_Data currPlayerData = null;
    public bool canPlay = false;

    public override void _Process(float delta)
    {
        base._Process(delta);

    }

    public ReferenceRect getReferenceRect(int boardPos)
    {
        return boardRects[boardPos-1] as ReferenceRect;
    }
}