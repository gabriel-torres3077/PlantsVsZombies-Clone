using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place_Tower : MonoBehaviour
{
    public int selected;
    public GameObject[] towers;
    public int[] prices;
    public GameObject Tile;
    private Sun sunScript;

    // Start is called before the first frame update
    void Start()
    {
        sunScript = GameObject.Find("GameSystem").GetComponent<Sun>();
        Debug.Log(towers);
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, 20))
        {
            if(hit.transform.tag == "Tile")
            {
                Tile = hit.transform.gameObject;
            }
            else
            {
                Tile = null;
            }
        }
        if(Input.GetMouseButtonDown(0) && Tile != null)
        {
            Tile_Choosen tile_script = Tile.GetComponent<Tile_Choosen>();
            if(!tile_script.isTaken && sunScript.sun >= prices[selected])
                {
                sunScript.sun -= prices[selected];
                Vector3 pos = new Vector3(Tile.transform.position.x, 0.2f, Tile.transform.position.z);
                tile_script.tower = (GameObject)Instantiate(towers[selected], pos, Quaternion.identity);
                tile_script.isTaken = true;
            }
        }
    }
}
