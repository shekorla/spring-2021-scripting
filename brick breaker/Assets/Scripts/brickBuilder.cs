using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class brickBuilder : MonoBehaviour
{
    public int brickCount=0, score,level=0, rowNum=1,colNum=1;
    public GameObject[] listOfBricks;


   //where to put bricks x1=1 , x2= 3.65, x3= 6.3, x4= 9, yoffset= 1,ystart=17;

    private void Start()
    {
        listOfBricks = Resources.LoadAll<GameObject>("BrickTypes");
        
        BuildBricks(level);
    }
    //build a random array of bricks
    //each array worth a certian number of points
    //4hit brick=4points etc.
    public void BuildBricks(int level)
    {
        for (int i = 0; i < level; i++)//spawn 4 blocks and move on
        {
            whereSpawn(1,i);
            new WaitForEndOfFrame();
            whereSpawn(2,i);
            new WaitForEndOfFrame();
            whereSpawn(3,i);   
            new WaitForEndOfFrame();
            whereSpawn(4,i);
            new WaitForEndOfFrame();
        }
    }

    public void makeOneBrick(Vector3 loc)
    {
        int whichBrick;
        if (level<3) {//up the difficulty
            whichBrick = Random.Range(0, level);
        }
        else {
            if (level>12)
            {
                whichBrick = Random.Range(1, 3); 
            }
            else {
                whichBrick = Random.Range(0, 3);
            }
        }
        GameObject newBrick=Instantiate(listOfBricks[whichBrick]) as GameObject;
        newBrick.transform.position = loc;
        brickCount++;
    }

    public void whereSpawn(int colNum,int rowNum)
    {
        var loc = new Vector3(0, 0, 0);
        if (colNum==4) { loc.x = 9; }
        if (colNum==3) { loc.x = (float) 6.3; }
        if (colNum==2) { loc.x = (float) 3.65; }
        if (colNum==1) { loc.x = 1; }
        loc.y = (17 - (rowNum * 1));
        makeOneBrick(loc);
    }

    private void Update()
    {
        if (brickCount <= 0)
        {
            new WaitForSecondsRealtime(2);
            level++;
            BuildBricks(level);
        }
    }
}
