/*
 * IDrop.cs
 * Script Author: Charles d'Ansembourg
 * Creation Date: 12/06/2024
 * Contact: c.dansembourg@icloud.com
 */

namespace Brotato_Clone
{
    public interface IDrop
    {
        int Value { get; }
        DropType Drop { get; }
    }
}