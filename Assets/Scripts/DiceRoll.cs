using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{

    public List<Sprite> dice_nums;

    public GameObject dice1;
    public GameObject dice2;
    //private SpriteRenderer diceSprite;

    private AudioSource sound;

    public int roll_value;

    // Start is called before the first frame update
    void Start()
    {
        //diceSprite = dice.GetComponent<SpriteRenderer>();
        sound = dice1.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Testing");
            roll_value = 0;
            StopAllCoroutines();
            StartCoroutine(roll(dice1));
            StartCoroutine(roll(dice2));
            sound.Play();

            //Debug.Log(final + 1);
        }
    }


    IEnumerator roll(GameObject dice)
    {

        SpriteRenderer diceSprite = dice.GetComponent<SpriteRenderer>();

        for (int i = 0; i < 8; i++)
        {
            diceSprite.sprite = dice_nums[Random.Range(0, 6)];
            yield return new WaitForSeconds(0.08f);
        }

        int final = Random.Range(0, 6);
        diceSprite.sprite = dice_nums[final];

        roll_value += final + 1;
    }
}
