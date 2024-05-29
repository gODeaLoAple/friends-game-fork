using System;

[Serializable]
public class ScoreEntry
{
    public string playerName;
    public int score;

    public ScoreEntry(string playerName, int score)
    {
        this.playerName = playerName;
        this.score = score;
    }
}