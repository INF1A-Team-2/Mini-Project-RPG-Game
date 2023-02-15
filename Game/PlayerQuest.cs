namespace Game;

class PlayerQuest
{
    public Quest Quest;
    public bool IsCompleted = false;

    public PlayerQuest(Quest quest)
    {
        this.Quest = quest;
    }
}