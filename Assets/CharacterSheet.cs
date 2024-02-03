using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSheet : MonoBehaviour
{
    [SerializeField]string Character_Name;
    [SerializeField] int ProficiencyBonus = 0;
    [SerializeField] bool FinesseWeapon = false;
    [SerializeField] [Range(-5,5)]int STR;
    [SerializeField] [Range(-5, 5)] int DEX;
    int enemyAC;
    int D20Roll;
    int HitModifier;
    
    // Start is called before the first frame update
    void Start()
    {
        if (FinesseWeapon == true)
        {
            if (STR > DEX)
            {
                HitModifier = ProficiencyBonus += STR;
                Debug.Log(Character_Name + "'s hit modifier is " + HitModifier);
            }
            else if(STR < DEX)
            {
                HitModifier = ProficiencyBonus += DEX;
                Debug.Log(Character_Name + "'s hit modifier is " + HitModifier);
            }
        }
        else if (FinesseWeapon == false)
        {
            HitModifier = ProficiencyBonus += STR;
            Debug.Log(Character_Name +"'s hit modifier is " + HitModifier);
        }
        
        enemyAC = Random.Range(10, 21);
        Debug.Log("Enemy Ac is " + enemyAC);
        D20Roll = Random.Range(10, 21);
        Debug.Log(Character_Name + "rolled a  " + D20Roll);

        if (HitModifier + D20Roll > enemyAC)
        {
            Debug.Log("Enemy is hit!");
        }
        if (HitModifier + D20Roll < enemyAC)
        {
            Debug.Log("Enemy is missed!");
        }
    }
}
