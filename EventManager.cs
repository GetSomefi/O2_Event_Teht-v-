namespace EventTehtava11;
/*
Näin teet Eventin
1. tee delegaatti
2. tee event, joka käyttää delegaattia
3. tee metodi mitä huudellaan (esim. kaikki subaajat saa samalla tiedon)
*/
class EventManager{
    public delegate void WriteDelegate(string[] textLines);

    public event WriteDelegate? WriteEvent;

    public void WriteTrigger(string[] textLines){
        WriteEvent?.Invoke(textLines);
    }
}