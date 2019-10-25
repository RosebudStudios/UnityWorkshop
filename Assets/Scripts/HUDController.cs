using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{

    public Text HungerText;
    public Text FriendText;
    public Text IsSickText;

    public GameObject Rock;

    // Start is called before the first frame update
    void Start()
    {
        /*HungerText.text = "I'm Hungry";
        FriendText.text = "Hello";
        IsSickText.text = "I'm Healthy";*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Rock != null)
        {
            HungerText.text = "Hunger: " + Rock.GetComponent<RockController>().hunger.ToString();
            FriendText.text = "Friendship: " + Rock.GetComponent<RockController>().friendship.ToString();
            IsSickText.text = "Sick: " + Rock.GetComponent<RockController>().isSick.ToString();
        }
    }

    public void Feed()
    {
        Rock.GetComponent<RockController>().hunger += 2;
    }

    public void PlayWithRock()
    {
        Rock.GetComponent<RockController>().friendship += 2;
    }

    public void TreatRock()
    {
        Rock.GetComponent<RockController>().isSick = false;
    }
}
 

