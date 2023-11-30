using UnityEngine;

public class GameManager : MonoBehaviour
{
    int songNumber = 1; //Change this if you add more songs to the game.
    public float songRPM;
    public int difficultyLevel; //Easy: 4 - Medium: 3 - Hard: 2
    public int drumCountNumber = 1;
    public int drumCountPermission = 0; //If it's 2, drumCount will be increased by 1.
    public bool isDrumActive;

    MalwareSpawner malwareSpawner;

    void Awake()
    {
        DefineSongRPM();
        DefineDifficulty();
    }

    void Start()
    {
        FindMalwareSpawner();
        SubscribeActions();
    }
    
    void FindMalwareSpawner() => malwareSpawner = FindObjectOfType<MalwareSpawner>();

    void SubscribeActions()
    {
        malwareSpawner.isDrumStarted += ActiveDrum;
        malwareSpawner.isDrumFinished += DeactiveDrum;
    }

    void DefineDifficulty() => difficultyLevel = 2; //TODO: JSON'DAN ÇEK BU DEĞERİ. ANA MENÜDE TIKLAYICA JSONA YAZ.

    void ActiveDrum() => isDrumActive = true;

    void DeactiveDrum() => isDrumActive = false;

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
    
    void UnsubscribeActions()
    {
        malwareSpawner.isDrumStarted -= ActiveDrum;
        malwareSpawner.isDrumFinished -= DeactiveDrum;
    }

    void OnDestroy() => UnsubscribeActions();
}
