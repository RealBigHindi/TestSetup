using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secretArenaScr : ScriptableObject {

    


    //Data
    public Vector2[] pathingMesh;
    GameObject[,] arenaMeshes;

    //ArenaMeshes
    public GameObject cube1_2_1;
    public GameObject cube1_1_1;
    public GameObject ramp1_1_1A;
    public GameObject ramp1_1_1B;
    public GameObject floorTile;

    private void Awake()
    {
        cube1_2_1 = Resources.Load<GameObject>("Prefabs/secretObj1");
        Debug.Log(cube1_2_1 != null);
        //GameObject cube1_1_1;
        //GameObject ramp1_1_1;
        floorTile = Resources.Load<GameObject>("Prefabs/secretFloorTile"); ;
        ramp1_1_1A = Resources.Load<GameObject>("Prefabs/secretRampA"); ;
        ramp1_1_1B = Resources.Load<GameObject>("Prefabs/secretRampB"); ;
    }


    public void Init(Texture2D _secretArenaImage, Texture2D _secretArenaPthfImage)
    {

        arenaMeshes = new GameObject[(int)_secretArenaImage.width, (int)_secretArenaImage.height];


        Debug.Log(cube1_2_1!=null);

        for (int x = 0; x < _secretArenaImage.width; x++)
        {
            for (int y = 0; y < _secretArenaImage.height; y++)
            {
                int _colourR = (int)_secretArenaImage.GetPixel(x, y).r * 255;
                int _colourG = (int)_secretArenaImage.GetPixel(x, y).g * 255;
                int _colourB = (int)_secretArenaImage.GetPixel(x, y).b * 255;

                string _colourString = _colourR.ToString() + _colourG.ToString() + _colourB.ToString();



                //Debug.Log(_colourString);

                switch (_colourString)
                {
                    case "000": //1_2_1 Cube
                        arenaMeshes[x, y] = Instantiate(cube1_2_1, new Vector3(x, 0, y), Quaternion.identity);
                        break;
                    case "255255255": //Floortile
                        arenaMeshes[x, y] = Instantiate(floorTile, new Vector3(x, 0, y), Quaternion.identity);
                        break;
                    case "02550": //RampB
                        arenaMeshes[x, y] = Instantiate(ramp1_1_1B, new Vector3(x, 0, y), Quaternion.identity);
                        break;
                    case "2552550": //RampA
                        arenaMeshes[x, y] = Instantiate(ramp1_1_1A, new Vector3(x, 0, y), Quaternion.identity);
                        break;
                }


            }
        }
    }
}
