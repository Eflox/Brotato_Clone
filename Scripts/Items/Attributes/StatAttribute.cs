/*
 * Script Author: Charles d'Ansembourg
 * Creation Date: 28/05/2024
 * Contact: c.dansembourg@icloud.com
 */

using System;

[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
public class StatAttribute : Attribute
{
    public bool IsMultiplier { get; }

    public StatAttribute(bool isMultiplier = false) => IsMultiplier = isMultiplier;
}
