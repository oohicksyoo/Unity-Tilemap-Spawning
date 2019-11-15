using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

namespace Project {
    public class Demo : MonoBehaviour {

        [SerializeField]
        private Tilemap tilemap;

        [SerializeField]
        private Tile spawnTile;

        public void Start() {
            
        }

        public void Update() {
            if (Input.GetMouseButtonDown(0)) {
                tilemap.SetTile(new Vector3Int(), spawnTile);
            }
        }
    }
}
