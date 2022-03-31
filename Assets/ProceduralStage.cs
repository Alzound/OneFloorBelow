using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace OneFloorBelow
{
    public class ProceduralStage : MonoBehaviour
    {
        [System.Serializable]
        public class Pool
        {
            public string tag;
            public GameObject prefab;
            public int size;
        }

        public List<Pool> pools;
        public Dictionary<string, Queue<GameObject>> poolDictionary;


        // Start is called before the first frame update
        void Start()
        {
            poolDictionary = new Dictionary<string, Queue<GameObject>>();

            foreach (Pool pool in pools)
            {
                Queue<GameObject> objectPool = new Queue<GameObject>();
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

