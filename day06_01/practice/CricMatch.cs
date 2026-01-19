using System;
public class CricMatch
{
    int[] playerScore = new int[5];
    int currentIndex;
    public void AddPlayerScore(int score)
    {
        if(score < 0 || score > 50)
        {
            throw new ArgumentException("Invalid score. Score must be between 0 and 50.");
        }
        if (currentIndex >= 5)
        {
            throw new InvalidOperationException("Cannot add more than 5 player scores.");
        }
        playerScore[currentIndex] = score;
        currentIndex++;
    }
    public int TotalTeamScore()
    {
        int sum=0;
        for(int i = 0; i < currentIndex; i++)
        {
            sum+= playerScore[i];
        }
        return sum;

    }
}