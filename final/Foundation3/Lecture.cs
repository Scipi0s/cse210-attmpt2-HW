public class Lecture : Event
{
    private string _speakerName;
    private string _lectureCapacity;

    public Lecture(string eventTitle, string eventType, string eventDescription, string eventDate, string eventTime, string eventAddress, string speakerName, string lectureCapacity) : base (eventTitle, eventType, eventDescription, eventDate, eventTime, eventAddress)
    {
        _speakerName = speakerName;
        _lectureCapacity = lectureCapacity;
    }

    public string GetLectureInfo()
    {
        return $"Speaker: {_speakerName}, Lecture Capacity: {_lectureCapacity}";
    }
}