﻿namespace Wingmann.PersonnelManagement.Personnel;

/// <summary>
/// 
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
    public Name(string first, string last)
    {
        First = first;
        Middle = string.Empty;
        Last = last;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="first"></param>
    /// <param name="middle"></param>
    /// <param name="last"></param>
    public Name(string first, string middle, string last)
    {
        First = first;
        Middle = middle;
        Last = last;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="newFirst"></param>
    public void ChangeFirst(string newFirst) => First = newFirst;
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="newMiddle"></param>
    public void ChangeMiddle(string newMiddle) => Middle = newMiddle;
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="newLast"></param>
    public void ChangeLast(string newLast) => Last = newLast;
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="newFirst"></param>
    /// <param name="newLast"></param>
    public void ChangeFull(string newFirst, string newLast)
    {
        First = newFirst;
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