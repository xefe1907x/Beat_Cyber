using UnityEngine;

public class GameManager : MonoBehaviour
{
    int songNumber = 1; //Change this if you add more songs to the game.
    public float songRPM;
    public int difficultyLevel; //Easy: 4 - Medium: 3 - Hard: 2

    void Awake()
    {
        DefineSongRPM();
        DefineDifficulty();
    }

    void DefineDifficulty()
    {
        difficultyLevel = 2; //TODO: JSON'DAN ÇEK BU DEĞERİ. ANA MENÜDE TIKLAYICA JSONA YAZ.
    }

    void DefineSongRPM()
    {
        switch (songNumber)
        {
            case 1:
                songRPM = 0.5f;
                break;
            //Add other cases if you add more songs.
        }
    }
}
