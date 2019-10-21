using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HeroChoose : MonoBehaviour
{
    public GameObject[] heroes = new GameObject[8];
    [Space]
    public GameObject maleRace;
    public GameObject femaleRace;
    [Space]
    public TextMeshProUGUI race;
    public TextMeshProUGUI description;
    public TextMeshProUGUI attributes;
    [Space]
    public GameObject toParentHero;

    [Header("Other")]
    public TextSetup textSetup;
    public PlayerInfo playerInfo;
    public EquipPlayer equipPlayer;
    
    public void ChangeRaceOfHero()
    {
      if (heroes[0].gameObject.activeInHierarchy || heroes[4].gameObject.activeInHierarchy) 
      {
        heroes[0].gameObject.SetActive(false);
        heroes[4].gameObject.SetActive(false);

        race.text = "Elf";
        textSetup.ElfsLor();
        description.text = textSetup.elfsLor;
        attributes.text = textSetup.elfsAbilities;

        heroes[1].gameObject.SetActive(true);
        heroes[5].gameObject.SetActive(true);
      }

      else if (heroes[1].gameObject.activeInHierarchy || heroes[5].gameObject.activeInHierarchy)
      {
        heroes[1].gameObject.SetActive(false);
        heroes[5].gameObject.SetActive(false);

        race.text = "Orc";
        textSetup.OrcsLor();
        description.text = textSetup.orcsLor;
        attributes.text = textSetup.orcsAbilities;

        heroes[2].gameObject.SetActive(true);
        heroes[6].gameObject.SetActive(true);
      }

      else if (heroes[2].gameObject.activeInHierarchy || heroes[6].gameObject.activeInHierarchy)
      {
        heroes[2].gameObject.SetActive(false);
        heroes[6].gameObject.SetActive(false);

        race.text = "Gnome";
        textSetup.GnomesLor();
        description.text = textSetup.gnomesLor;
        attributes.text = textSetup.gnomesAbilities;

        heroes[3].gameObject.SetActive(true);
        heroes[7].gameObject.SetActive(true);
      }

      else if (heroes[3].gameObject.activeInHierarchy || heroes[7].gameObject.activeInHierarchy)
      {
        heroes[3].gameObject.SetActive(false);
        heroes[7].gameObject.SetActive(false);

        race.text = "Human";
        textSetup.HumanLor();
        description.text = textSetup.humanLor;
        attributes.text = textSetup.humanAbilities;

        heroes[0].gameObject.SetActive(true);
        heroes[4].gameObject.SetActive(true);
      }
    }

    public void MaleRace()
    {   
        femaleRace.SetActive(false);
        maleRace.SetActive(true);
    }

    public void FemaleRace()
    {
        maleRace.SetActive(false);
        femaleRace.SetActive(true);
    }

    public void SetParent()
    {
      foreach (GameObject hero in heroes)
      {
          if (hero.activeInHierarchy)
          {
            hero.transform.parent = toParentHero.transform;

            equipPlayer = FindObjectOfType<EquipPlayer>();
            equipPlayer.player = hero;
            equipPlayer.weaponAttach = GameObject.FindGameObjectWithTag("Weapon Attachment");
            equipPlayer.shieldAttach = GameObject.FindGameObjectWithTag("Shield Attachment");
          
            GameObject playerBody = GameObject.FindGameObjectWithTag("Player Body Mesh");
            GameObject playerHair = GameObject.FindGameObjectWithTag("Player Hair Mesh");
            equipPlayer.playerBodySkinMesh = playerBody.GetComponent<SkinnedMeshRenderer>();
            equipPlayer.playerHairSkinMesh = playerHair.GetComponent<SkinnedMeshRenderer>();

            playerInfo.playerRace = race.text;
            playerInfo.playerLor = description.text;
            playerInfo.playerAbilities = attributes.text;
          }
      }  
    }
}
