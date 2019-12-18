namespace ProductivityTools.ReleaseManagment.App
{
    public interface IDictionary
    {
        int GetDVId(string dictionaryName, string dictValueKey);
        int GetDictionaryId(string dictionaryName);
    }
}