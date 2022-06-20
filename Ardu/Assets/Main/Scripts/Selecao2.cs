    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
 
 public class Selecao2 : MonoBehaviour
 {
      public enum Type{ One, Two, Three}
      public Type type;
      void Start()
      {
           switch(type)
           {
                case Type.One:
                     Debug.Log("One");
                break;
 
                case Type.Two:
                     Debug.Log("Two");
                break;
 
                case Type.Three:
                     Debug.Log("Three");
                break;
           }
      }
 }


