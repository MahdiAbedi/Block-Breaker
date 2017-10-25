using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour {
    public int maxHits;
    public Sprite[] hitSprite;
    public AudioClip clip;

    private static int blockCounter=0;//for couting how many blocks is in the game
    private LevelManager levelmanager;
    private int timesHit;
	// Use this for initialization
	void Start () {
        levelmanager = FindObjectOfType<LevelManager>();
        blockCounter++;//each blocks counts itself
        print(blockCounter);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        AudioSource.PlayClipAtPoint(clip,transform.position);
        timesHit++;
        if (timesHit>=maxHits)
        {
            Destroy(gameObject);
            blockCounter--;
        }
        else
        {
            int spriteIndex = timesHit - 1;
            this.GetComponent<SpriteRenderer>().sprite = hitSprite[spriteIndex]; 
        }
        if (blockCounter<=0)
        {
            SimulateWin();
        }
       // SimulateWin();
        
    }
    void SimulateWin()
    {
        levelmanager.LoadNextLevel();
    }
}
