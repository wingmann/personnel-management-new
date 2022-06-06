namespace Wingmann.PersonnelManagement.Personnel;

/// <summary>
/// Implements name.
/// </summary>
public class Name
{
    /// <summary>
    /// 
    /// </summary>
    public string First { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public string Middle { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    public string Last { get; private set; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="first"></param>
    /// <param name="last"></param>
    public Name(string first, string last) => ChangeFull(first, last);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="first"></param>
    /// <param name="middle"></param>
    /// <param name="last"></param>
    public Name(string first, string middle, string last) => ChangeFull(first, middle, last);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="newFirst"></param>
    /// <param name="newLast"></param>
    public void ChangeFull(string newFirst, string newLast)
    {
        First = newFirst;
        Middle = string.Empty;
        Last = newLast;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="newFirst"></param>
    /// <param name="newMiddle"></param>
    /// <param name="newLast"></param>
    public void ChangeFull(string newFirst, string newMiddle, string newLast)
    {
        First = newFirst;
        Middle = newMiddle;
        Last = newLast;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString() => $"{First} {Middle} {Last}";
}
