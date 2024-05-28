# Define the list of characters
$characters = @(
    "Mage", 
    "Brawler", 
    "Crazy", 
    "WellRounded", 
    "Chunky", 
    "Old", 
    "Lucky", 
    "Farmer", 
    "Ghost", 
    "Speedy", 
    "Entrepreneur", 
    "Knight", 
    "Hunter", 
    "Glutton", 
    "Jack", 
    "Golem", 
    "Renegade", 
    "Ranger", 
    "Loud", 
    "Multitasker", 
    "Pacifist", 
    "Saver", 
    "Sick", 
    "Engineer", 
    "Explorer", 
    "Demon", 
    "Artificer", 
    "Cyborg", 
    "Fisherman", 
    "Mutant", 
    "Generalist", 
    "Doctor", 
    "OneArmed", 
    "Bull", 
    "Masochist", 
    "ArmsDealer", 
    "Lich", 
    "Apprentice", 
    "Cryptid", 
    "King", 
    "Wildling", 
    "Gladiator", 
    "Soldier", 
    "Streamer"
)

# Loop through each character and create a .cs file
foreach ($character in $characters) {
    $content = @"
using UnityEngine;

[CreateAssetMenu(fileName = "$character", menuName = "Game/Characters/$character")]
public class $character : ItemBase, IItem
{
}
"@

    # Create the file with the class definition
    $fileName = "$character.cs"
    $content | Out-File $fileName
}
