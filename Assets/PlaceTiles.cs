using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;

public class PlaceTiles : MonoBehaviour {


	public GameObject tile;

	public Sprite[] tileSprites;

	// Use this for initialization
	void Start () {


		tileSprites = Resources.LoadAll<Sprite>("cpu");

		//print(Application.persistentDataPath);

		var mapReader = new StreamReader(File.OpenRead(@"Assets/map.csv"));

		int colCount = 0;


		List<int[]> mapRows = new List<int[]> ();

		while (!mapReader.EndOfStream)
		{
			string line = mapReader.ReadLine();
			if(line[0]!='#')
			{
				string[] entries=line.Split(',');
				if(colCount==0)
				{
					colCount=entries.Length;
				}

				int[] curRow=new int[colCount];
				for (int i = 0; i < colCount; i++) {
					curRow[i]=int.Parse(entries[i]);
				}
				mapRows.Add(curRow);
			}
		}

		//print ("You clicked me!");


		for (int r = 0; r < mapRows.Count; r++) {
			for (int c = 0; c < colCount; c++) {

				GameObject instance=(GameObject)Instantiate(tile);

				switch (mapRows[r][c]) {
				case 0:

					break;
				case 1:
					SpriteRenderer renderer=instance.GetComponent<SpriteRenderer>();
					renderer.sprite=tileSprites[0];
					break;
				default:
				break;
				}




				instance.transform.position=new Vector2(r,c); 
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
