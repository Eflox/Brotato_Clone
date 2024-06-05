/*
 * StatAttribute.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using System;

public enum StatOperation
{
    Add,
    Set
}

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class StatAttribute : Attribute
{
    public bool IsMultiplier { get; }
    public StatOperation Operation { get; }

    public StatAttribute(bool isMultiplier = false, StatOperation operation = StatOperation.Add)
    {
        IsMultiplier = isMultiplier;
        Operation = operation;
    }
}