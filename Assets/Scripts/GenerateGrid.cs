using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.AI.Navigation;

public class GenerateGrid : MonoBehaviour
{    
    public GameObject blockGameObject;

    public GameObject blockGameObject2; 

    public GameObject housething1;

    public GameObject stuff2;

    private int worldSizeX = 15;

    private int worldSizeZ = 15;

    private int gridOffset = 10; //PLEASE DON'T TOUCH THIS, ITS WEIRD, IT MESSES WITH THE GENERATION TOO MUCH
                                 //JUST IN CASE IF CHANGED: Keep changing this value till tiles connect with
                                 //each other. MAKE SURE TO PRESS PLAY TWICE!

                                    //ACTUALLY please don't touch anything involving 'world' lmao

    

    // Start is called before the first frame update
    void Start()
    {
        for (int x = 0; x < worldSizeX; x++) //loop1
        {
            for(int z = 0; z < worldSizeZ; z++) //loop2
            {
                
                Vector3 pos = new Vector3(x * gridOffset, 0, z * gridOffset);

                switch (Random.Range(3, 10) == Random.Range(3,10))
                {
                    
                    case true:
                        print(x);
                        GameObject block = Instantiate(blockGameObject, pos, Quaternion.identity) as GameObject;

                        block.transform.SetParent(this.transform);

                        break;

                    case false:
                        print(x);
                        GameObject block2 = Instantiate(blockGameObject2, pos, Quaternion.identity) as GameObject;

                        block2.transform.SetParent(this.transform);

                        break;


                }
                switch (Random.Range(10, 15) == Random.Range(10,15))
                {
                    
                    case true:
                        print(x);
                        GameObject block = Instantiate(blockGameObject, pos, Quaternion.identity) as GameObject;

                        block.transform.SetParent(this.transform);

                        break;

                    case false:
                        print(x);
                        GameObject block2 = Instantiate(blockGameObject2, pos, Quaternion.identity) as GameObject;

                        block2.transform.SetParent(this.transform);

                        break;


                }
                switch (Random.Range(10, 15) == Random.Range(10,15))
                {
                    
                    case true:
                        print(x);
                        GameObject block = Instantiate(blockGameObject, pos, Quaternion.identity) as GameObject;

                        block.transform.SetParent(this.transform);

                        break;

                    case false:
                        print(x);
                        GameObject block2 = Instantiate(blockGameObject2, pos, Quaternion.identity) as GameObject;

                        block2.transform.SetParent(this.transform);

                        break;


                }
                
                if(x == Random.Range(0, 8))
                {
                    GameObject block = Instantiate(housething1, pos, Quaternion.identity) as GameObject;

                    block.transform.SetParent(this.transform);
                }
                else if(z == Random.Range(0, 8))
                {
                    GameObject block2 = Instantiate(stuff2, pos, Quaternion.identity) as GameObject;

                    block2.transform.SetParent(this.transform);
                }

                if(x == Random.Range(8, 15))
                {
                    GameObject block = Instantiate(housething1, pos, Quaternion.identity) as GameObject;

                    block.transform.SetParent(this.transform);
                }
                else if(z == Random.Range(8, 15))
                {
                    GameObject block2 = Instantiate(stuff2, pos, Quaternion.identity) as GameObject;

                    block2.transform.SetParent(this.transform);
                }
                   

            }
        }
    }
}
